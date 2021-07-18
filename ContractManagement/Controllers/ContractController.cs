using ContractManagement.Application.ApplicationServices.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ContractManagement.Controllers
{
    public class ContractController : Controller
    {
        private readonly IContractApplicationService contractApplicationService;

        public ContractController(IContractApplicationService contractApplicationService)
        {
            this.contractApplicationService = contractApplicationService;
        }

        public async Task<IActionResult> List()
        {
            var viewModel = await this.contractApplicationService.GetListViewModel(this.Request);
            return View(viewModel);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var viewModel = await this.contractApplicationService.GetContractViewModel(id);
            return View(viewModel);
        }
    }
}
