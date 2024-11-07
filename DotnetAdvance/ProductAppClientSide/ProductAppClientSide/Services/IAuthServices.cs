using ProductAppClientSide.Models;
namespace ProductAppClientSide.Services
{
    public interface IAuthServices
    {
        
            Task<string> AuthenticateAsync(UserLogin loginModel);
        

    }
}
