using ProductAppClientSide.Models;
using System.Text.Json;
using System.Text;

namespace ProductAppClientSide.Services
{
    public class AuthService :IAuthServices
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> AuthenticateAsync(UserLogin loginModel) 
        {
            var content = new StringContent(JsonSerializer.Serialize(loginModel), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:7290/api/Auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var jsonResponse = JsonSerializer.Deserialize<JsonElement>(responseContent);
                return jsonResponse.GetProperty("token").GetString();
            }

            return null;
        }

    }
}
