using ContractManagement.Application.ApplicationServices.Institutions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ContractManagement.Controllers
{
    public class InstitutionController : Controller
    {
        private readonly IInstitutionApplicationService institutionApplicationService;

        public InstitutionController(IInstitutionApplicationService institutionApplicationService)
        {
            this.institutionApplicationService = institutionApplicationService;
        }

        public async Task<IActionResult> List()
        {
            var viewModel = await this.institutionApplicationService.GetListViewModel(this.Request);
            return View(viewModel);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var viewModel = await this.institutionApplicationService.GetInstitutionViewModel(id);
            return View(viewModel);
        }
    }
}
