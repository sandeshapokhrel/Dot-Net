﻿using Microsoft.IdentityModel.Tokens;
using ProductAppApi.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ProductAppApi.Utilities;

public class JwtTokenHelper
{
    private readonly IConfiguration _configuration;
    public JwtTokenHelper(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateToken(User user)
    {
        var securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[] {
            new Claim(ClaimTypes.Name,user.Username),
            new Claim(ClaimTypes.Name,user.Role)
        };

        var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
            _configuration["Jwt:Audience"]
            , claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpirationMinutes"])),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);

    }
}
