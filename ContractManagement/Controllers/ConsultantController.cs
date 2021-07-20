using ContractManagement.Application.ApplicationServices.Consultants;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ContractManagement.Controllers
{
    public class ConsultantController : Controller
    {
        private readonly IConsultantApplicationService consultantApplicationService;

        public ConsultantController(IConsultantApplicationService consultantApplicationService)
        {
            this.consultantApplicationService = consultantApplicationService;
        }

        // Returns view with list of consultants based on request
        public async Task<IActionResult> List()
        {
            var viewModel = await this.consultantApplicationService.GetListViewModel(this.Request);
            return View(viewModel);
        }

        // Returns view with detail informations about consultant with given id
        public async Task<IActionResult> Detail(int id)
        {
            var viewModel = await this.consultantApplicationService.GetConsultantViewModel(id);
            return View(viewModel);
        }

        // Returns CSV file with exported consultants
        public async Task<IActionResult> CsvExport()
        {
            var csvExportResult = await this.consultantApplicationService.GetCsvExportResult();
            return File(csvExportResult.Data, csvExportResult.ContentType, csvExportResult.Filename);
        }
    }
}
