using ContractManagement.Application.ViewModels.Clients;
using ContractManagement.Application.ViewModels.Consultants;
using ContractManagement.Application.ViewModels.Institutions;
using System.Collections.Generic;

namespace ContractManagement.Application.ViewModels.Contracts
{
    public class ListViewModel
    {
        public IList<ContractViewModel> Contracts { get; set; }

        public IList<InstitutionViewModel> Institutions { get; set; }

        public IList<ClientViewModel> Clients { get; set; }

        public IList<ConsultantViewModel> Administrators { get; set; }
    }
}
