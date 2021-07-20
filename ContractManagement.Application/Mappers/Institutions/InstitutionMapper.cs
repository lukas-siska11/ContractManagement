using ContractManagement.Application.ViewModels.Institutions;
using ContractManagement.Domain.Entities.Institutions;
using System.Collections.Generic;

namespace ContractManagement.Application.Mappers.Institutions
{
    // Maps entities from domain layer to view models
    public class InstitutionMapper
    {
        public InstitutionViewModel Map(Institution entity)
        {
            var viewModel = new InstitutionViewModel();

            viewModel.ID = entity.ID;
            viewModel.Name = entity.Name;

            return viewModel;
        }

        public IList<InstitutionViewModel> MapMultiple(IList<Institution> institutions)
        {
            var list = new List<InstitutionViewModel>();
            foreach (var institution in institutions)
            {
                list.Add(this.Map(institution));
            }

            return list;
        }

        public ListViewModel MapList(IList<Institution> institutions)
        {
            var viewModel = new ListViewModel();

            viewModel.Institutions = this.MapMultiple(institutions);

            return viewModel;
        }
    }
}
