using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApp.Data;
using ProductApp.Models;
using ProductApp.Services;
using Microsoft.Extensions.Logging;

namespace ProductApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DemoDbContext _demodbContext;
        private readonly ILogger<ProductController> _logger; // Declare the logger

        public ProductController(DemoDbContext demodbContext, ILogger<ProductController> logger) // Only one constructor
        {
            _demodbContext = demodbContext;
            _logger = logger;
        }

        // GET: api/product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            var products = await _demodbContext.Products.ToListAsync();
            return Ok(products); // Return products wrapped in Ok()
        }

        // GET: api/product/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await _demodbContext.Products.SingleOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound(); // Return NotFound if product doesn't exist
            }
            return Ok(product); // Return product wrapped in Ok()
        }

        // POST: api/product
        [HttpPost]
        public async Task<ActionResult<Product>> Create([FromBody] Product product)
        {
            // Ensure the incoming product is valid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return validation errors if any
            }

            // Add product to the database
            await _demodbContext.Products.AddAsync(product);
            await _demodbContext.SaveChangesAsync();

            // Return a 201 Created response with the new product's details
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }


        // PUT: api/product/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest(); // Return BadRequest if IDs do not match
            }

            _demodbContext.Products.Update(product);
            await _demodbContext.SaveChangesAsync();
            return NoContent(); // Return NoContent if update is successful
        }

        // DELETE: api/product/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product = await _demodbContext.Products.FindAsync(id); // Directly retrieve the product by ID
            if (product == null)
            {
                return NotFound(new { message = $"Product with ID {id} not found" }); // Return custom NotFound message
            }

            _demodbContext.Products.Remove(product);
            await _demodbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile productImage, int productId)
        {
            if (productImage == null || productImage.Length == 0)
            {
                return BadRequest(new { message = "No file uploaded" });
            }

            try
            {
                // Check if the product exists
                var product = await _demodbContext.Products.FindAsync(productId);
                if (product == null)
                {
                    return NotFound(new { message = "Product not found" });
                }

                // Generate unique filename and ensure the images directory exists
                var fileName = Guid.NewGuid() + Path.GetExtension(productImage.FileName);
                var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // File path for saving
                var filePath = Path.Combine(directoryPath, fileName);

                // Copy file to server
                await using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await productImage.CopyToAsync(stream);
                }

                // Convert image to base64 string for storing in database
                string base64Image;
                await using (var ms = new MemoryStream())
                {
                    await productImage.CopyToAsync(ms);
                    base64Image = Convert.ToBase64String(ms.ToArray());
                }

                // Save image details to the database
                var imageDetail = new ImageDetail
                {
                    ProductImage = fileName,
                    ImagePath = filePath,
                    Base64Image = base64Image
                };

                await _demodbContext.ImageDetails.AddAsync(imageDetail);
                await _demodbContext.SaveChangesAsync();

                // Link the product with the uploaded image
                product.ImageUrl = fileName;
                _demodbContext.Products.Update(product);
                await _demodbContext.SaveChangesAsync();

                return Ok(new { message = "File uploaded successfully", fileName });
            }
            catch (Exception ex)
            {
                // Log the error
                _logger.LogError(ex, "An error occurred while uploading the file.");

                return StatusCode(500, new { message = "Internal server error", error = ex.InnerException?.Message ?? ex.Message });
            }
        }




    }
}