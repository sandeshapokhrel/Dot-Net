using System.Text.Json.Serialization;

namespace ProductApp.Models
{
    public class ImageDetail
    {
        public int Id { get; set; }
        public string ProductImage { get; set; } = null!;

        public string ImagePath { get; set; } = null!;

        public string Base64Image { get; set; } = null!;
        public int ProductId { get; set; }

        [JsonIgnore] // This will prevent the property from being serialized
        public Product Product { get; set; } = null!;

    }
}
