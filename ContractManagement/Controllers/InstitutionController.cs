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

        // Returns view with list of institutions based on request
        public async Task<IActionResult> List()
        {
            var viewModel = await this.institutionApplicationService.GetListViewModel(this.Request);
            return View(viewModel);
        }

        // Returns view with detail informations about contract with given id
        public async Task<IActionResult> Detail(int id)
        {
            var viewModel = await this.institutionApplicationService.GetInstitutionViewModel(id);
            return View(viewModel);
        }
    }
}
