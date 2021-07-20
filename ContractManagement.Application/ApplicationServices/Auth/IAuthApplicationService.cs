using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Auth
{
    public interface IAuthApplicationService
    {
        // Provides user sign in by username and password
        Task<bool> SignIn(string username, string password);

        // Provides user sign out
        Task<bool> SignOut();
    }
}
