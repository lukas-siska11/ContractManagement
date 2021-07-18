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

        public async Task<IActionResult> List()
        {
            var viewModel = await this.consultantApplicationService.GetListViewModel(this.Request);
            return View(viewModel);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var viewModel = await this.consultantApplicationService.GetConsultantViewModel(id);
            return View(viewModel);
        }
    }
}
