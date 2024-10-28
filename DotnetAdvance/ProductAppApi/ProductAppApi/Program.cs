using Microsoft.AspNetCore.Authentication.JwtBearer; // Add this
using Microsoft.IdentityModel.Tokens; // Add this for SecurityKey
using ProductAppApi.Data;
using ProductAppApi.Models;
using Microsoft.OpenApi.Models;
using ProductAppApi.Repositories;
using ProductAppApi.Services;
using ProductAppApi.Utilities; // Import the JwtTokenHelper class namespace
using System.Text; // For Encoding
using Microsoft.EntityFrameworkCore;
using ProductApi.Services;

namespace ProductAppApi
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

            // Add JWT Authentication
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                };
            });

            // Register your services
            builder.Services.AddScoped<IproductRepo, productRepo>(); // Register Product Repository
            builder.Services.AddScoped<IproductService, ProductService>(); // Register Product Service
            builder.Services.AddScoped<IUserRepo, UserRepo>(); // Register User Repository
            builder.Services.AddScoped<IUserService, UserService>(); // Register User Service
            builder.Services.AddSingleton<JwtTokenHelper>(); // Register the JwtTokenHelper

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
            app.UseAuthentication(); // Enable authentication
            app.UseAuthorization();

            app.MapControllers(); // This will map all attribute-routed controllers

            app.Run();
        }
    }
}
