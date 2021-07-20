using ContractManagement.Application.ViewModels.Institutions;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Institutions
{
    public interface IInstitutionApplicationService
    {
        // Gets list view model without beining modified by request
        Task<ListViewModel> GetListViewModel();

        // Gets list view model with modifications from request
        Task<ListViewModel> GetListViewModel(HttpRequest request);

        // Gets single institution view model by given id
        Task<InstitutionViewModel> GetInstitutionViewModel(int id);
    }
}
