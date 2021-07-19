using ContractManagement.Domain.Services.Auth;
using ContractManagement.Infrastructure.Identity.Users;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ContractManagement.Infrastructure.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly SignInManager<User> signInManager;

        public AuthService(SignInManager<User> signInManager)
        {
            this.signInManager = signInManager;
        }

        public async Task<bool> SignIn(string username, string password)
        {
            var result = await this.signInManager.PasswordSignInAsync(username, password, false, false);
            return result.Succeeded;
        }

        public async Task<bool> SignOut()
        {
            await this.signInManager.SignOutAsync();
            return true;
        }
    }
}
