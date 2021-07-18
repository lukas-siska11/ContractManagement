using ContractManagement.Application.ViewModels.Clients;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Clients
{
    public interface IClientApplicationService
    {
        Task<ListViewModel> GetListViewModel();
        Task<ListViewModel> GetListViewModel(HttpRequest request);
        Task<ClientViewModel> GetClientViewModel(int id);
    }
}
