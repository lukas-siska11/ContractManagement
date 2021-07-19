using System.Collections.Generic;

namespace ContractManagement.Application.ViewModels.Institutions
{
    public class ListViewModel : IViewModel
    {
        public IList<InstitutionViewModel> Institutions { get; set; }
    }
}
