using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Auth
{
    public interface IAuthApplicationService
    {
        Task<bool> SignIn(string username, string password);

        Task<bool> SignOut();
    }
}
