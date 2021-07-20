using ContractManagement.Application.ApplicationServices.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
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

        // Returns view with list of contracts and filters based on request
        public async Task<IActionResult> List()
        {
            var viewModel = await this.contractApplicationService.GetListViewModel(this.Request);

            var institutionSelectItems = new List<SelectListItem>();
            foreach (var institution in viewModel.Institutions)
            {
                institutionSelectItems.Add(new SelectListItem()
                {
                    Text = institution.Name,
                    Value = institution.ID.ToString()
                });
            }
            ViewBag.InstitutionSelectList = new SelectList(institutionSelectItems, "Value", "Text");

            var clientSelectItems = new List<SelectListItem>();
            foreach (var client in viewModel.Clients)
            {
                clientSelectItems.Add(new SelectListItem()
                {
                    Text = client.FullName,
                    Value = client.ID.ToString()
                });
            }
            ViewBag.ClientSelectList = new SelectList(clientSelectItems, "Value", "Text");

            var administratorSelectItems = new List<SelectListItem>();
            foreach (var administrator in viewModel.Administrators)
            {
                administratorSelectItems.Add(new SelectListItem()
                {
                    Text = administrator.FullName,
                    Value = administrator.ID.ToString()
                });
            }
            ViewBag.AdministratorSelectList = new SelectList(administratorSelectItems, "Value", "Text");

            return View(viewModel);
        }

        // Returns view with detail informations about contract with given id
        public async Task<IActionResult> Detail(int id)
        {
            var viewModel = await this.contractApplicationService.GetContractViewModel(id);
            return View(viewModel);
        }

        // Returns CSV file with exported contracts
        public async Task<IActionResult> CsvExport()
        {
            var csvExportResult = await this.contractApplicationService.GetCsvExportResult();
            return File(csvExportResult.Data, csvExportResult.ContentType, csvExportResult.Filename);
        }
    }
}
