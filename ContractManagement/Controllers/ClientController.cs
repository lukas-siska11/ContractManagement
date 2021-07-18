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

        public async Task<IActionResult> List()
        {
            var viewModel = await this.clientApplicationService.GetListViewModel(this.Request);
            return View(viewModel);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var viewModel = await this.clientApplicationService.GetClientViewModel(id);
            return View(viewModel);
        }
    }
}
