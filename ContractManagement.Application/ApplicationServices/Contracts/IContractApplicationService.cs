using ContractManagement.Application.ViewModels.Contracts;
using ContractManagement.Domain.Services.Export;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Contracts
{
    public interface IContractApplicationService
    {
        // Gets list view model without beining modified by request
        Task<ListViewModel> GetListViewModel();

        // Gets list view model with modifications from request
        Task<ListViewModel> GetListViewModel(HttpRequest request);

        // Gets single contract view model by given id
        Task<ContractViewModel> GetContractViewModel(int id);

        // Exports contracts into CSV file
        Task<CsvExportResult> GetCsvExportResult();
    }
}
