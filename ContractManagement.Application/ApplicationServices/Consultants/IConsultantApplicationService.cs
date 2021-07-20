using ContractManagement.Application.ViewModels.Consultants;
using ContractManagement.Domain.Services.Export;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Consultants
{
    public interface IConsultantApplicationService
    {
        // Gets list view model without beining modified by request
        Task<ListViewModel> GetListViewModel();

        // Gets list view model with modifications from request
        Task<ListViewModel> GetListViewModel(HttpRequest request);

        // Gets single consultant view model by given id
        Task<ConsultantViewModel> GetConsultantViewModel(int id);

        // Exports consultants into CSV file
        Task<CsvExportResult> GetCsvExportResult();
    }
}
