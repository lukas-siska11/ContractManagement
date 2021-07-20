using ContractManagement.Application.ViewModels.Clients;
using ContractManagement.Application.ViewModels.Consultants;
using ContractManagement.Application.ViewModels.Institutions;
using System.Collections.Generic;

namespace ContractManagement.Application.ViewModels.Contracts
{
    public class ListViewModel : PaginationViewModel, IViewModel
    {
        public IList<ContractViewModel> Contracts { get; set; }

        public IList<InstitutionViewModel> Institutions { get; set; }

        public string InstitutionId { get; set; }

        public IList<ClientViewModel> Clients { get; set; }

        public string ClientId { get; set; }

        public IList<ConsultantViewModel> Administrators { get; set; }

        public string AdministratorId { get; set; }

        public string Search { get; set; }
    }
}
