using ContractManagement.Application.ViewModels.Clients;
using ContractManagement.Domain.Services.Export;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Clients
{
    public interface IClientApplicationService
    {
        // Gets list view model without beining modified by request
        Task<ListViewModel> GetListViewModel();

        // Gets list view model with modifications from request
        Task<ListViewModel> GetListViewModel(HttpRequest request);

        // Gets single client view model by given id
        Task<ClientViewModel> GetClientViewModel(int id);

        // Exports clients into CSV file
        Task<CsvExportResult> GetCsvExportResult();
    }
}
