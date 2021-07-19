using System.Threading.Tasks;

namespace ContractManagement.Domain.Services.Auth
{
    public interface IAuthService
    {
        Task<bool> SignIn(string username, string password);

        Task<bool> SignOut();
    }
}
