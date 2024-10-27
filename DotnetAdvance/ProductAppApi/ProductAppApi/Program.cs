using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAppApi.Data;
using ProductAppApi.Models;
using Microsoft.OpenApi.Models;
using ProductAppApi.Repositories;
using ProductAppApi.Services;
using ProductAppApi.Data;
using ProductAppApi.Repositories;
using ProductAppApi.Services;

namespace ProductApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            // Configure Swagger
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Product API", Version = "v1" });
                // Removed XML comments inclusion
            });

            // Configure Database Context
            builder.Services.AddDbContext<DemoDbContext>(options =>
            {
                var DefaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(DefaultConnection);
            });

            // Configure CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            builder.Services.AddScoped<IproductRepo, productRepo>();
            builder.Services.AddScoped<IproductService, ProductService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();       // Add Swagger middleware to generate OpenAPI docs
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API v1"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors("AllowAll"); // Enable CORS
            app.UseAuthorization();

            app.MapControllers(); // This will map all attribute-routed controllers

            app.Run();
        }
    }
}
