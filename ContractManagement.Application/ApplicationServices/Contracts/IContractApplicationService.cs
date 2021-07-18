using ContractManagement.Application.ViewModels.Contracts;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Contracts
{
    public interface IContractApplicationService
    {
        Task<ListViewModel> GetListViewModel();
        Task<ListViewModel> GetListViewModel(HttpRequest request);
        Task<ContractViewModel> GetContractViewModel(int id);
    }
}
