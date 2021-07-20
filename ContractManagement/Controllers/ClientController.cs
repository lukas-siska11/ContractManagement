using ContractManagement.Application.ApplicationServices.Clients;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ContractManagement.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientApplicationService clientApplicationService;

        public ClientController(IClientApplicationService clientApplicationService)
        {
            this.clientApplicationService = clientApplicationService;
        }

        // Returns view with list of clients based on request
        public async Task<IActionResult> List()
        {
            var viewModel = await this.clientApplicationService.GetListViewModel(this.Request);
            return View(viewModel);
        }

        // Returns view with detail informations about client with given id
        public async Task<IActionResult> Detail(int id)
        {
            var viewModel = await this.clientApplicationService.GetClientViewModel(id);
            return View(viewModel);
        }

        // Returns CSV file with exported clients
        public async Task<IActionResult> CsvExport()
        {
            var csvExportResult = await this.clientApplicationService.GetCsvExportResult();
            return File(csvExportResult.Data, csvExportResult.ContentType, csvExportResult.Filename);
        }
    }
}
