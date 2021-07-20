using System.Collections.Generic;

namespace ContractManagement.Application.ViewModels.Consultants
{
    public class ListViewModel : PaginationViewModel, IViewModel
    {
        public IList<ConsultantViewModel> Consultants { get; set; }

        public string Search { get; set; }
    }
}
