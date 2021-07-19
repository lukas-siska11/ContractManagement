using ContractManagement.Domain.Services.Auth;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Auth
{
    public class AuthApplicationService : IAuthApplicationService
    {
        private readonly IAuthService authService;

        public AuthApplicationService(IAuthService authService)
        {
            this.authService = authService;
        }

        public async Task<bool> SignIn(string username, string password)
        {
            return await this.authService.SignIn(username, password);
        }

        public async Task<bool> SignOut()
        {
            return await this.authService.SignOut();
        }
    }
}
