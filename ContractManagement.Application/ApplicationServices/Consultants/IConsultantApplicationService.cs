using ContractManagement.Application.ViewModels.Consultants;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Consultants
{
    public interface IConsultantApplicationService
    {
        Task<ListViewModel> GetListViewModel();
        Task<ListViewModel> GetListViewModel(HttpRequest request);
        Task<ConsultantViewModel> GetConsultantViewModel(int id);
    }
}
