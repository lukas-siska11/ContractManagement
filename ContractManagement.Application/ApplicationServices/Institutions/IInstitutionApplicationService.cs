using ContractManagement.Application.ViewModels.Institutions;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Institutions
{
    public interface IInstitutionApplicationService
    {
        Task<ListViewModel> GetListViewModel();
        Task<ListViewModel> GetListViewModel(HttpRequest request);
        Task<InstitutionViewModel> GetInstitutionViewModel(int id);
    }
}
