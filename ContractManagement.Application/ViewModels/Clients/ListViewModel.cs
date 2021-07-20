using System.Collections.Generic;

namespace ContractManagement.Application.ViewModels.Clients
{
    public class ListViewModel : PaginationViewModel, IViewModel
    {
        public IList<ClientViewModel> Clients { get; set; }

        public string Search { get; set; }
    }
}
