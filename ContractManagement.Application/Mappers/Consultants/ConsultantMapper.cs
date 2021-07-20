using ContractManagement.Application.ViewModels.Consultants;
using ContractManagement.Domain.Entities.Consultants;
using System.Collections.Generic;

namespace ContractManagement.Application.Mappers.Consultants
{
    // Maps entities from domain layer to view models
    public class ConsultantMapper
    {
        public ConsultantViewModel Map(Consultant entity)
        {
            var viewModel = new ConsultantViewModel();

            viewModel.ID = entity.ID;
            viewModel.Name = entity.Name;
            viewModel.Surname = entity.Surname;
            viewModel.Email = entity.Email;
            viewModel.Phone = entity.Phone;
            viewModel.Age = entity.Age;
            viewModel.PersonalIdentificationNumber = entity.PersonalIdentificationNumber;

            return viewModel;
        }

        public IList<ConsultantViewModel> MapMultiple(IList<Consultant> consultants)
        {
            var list = new List<ConsultantViewModel>();
            foreach (var consultant in consultants)
            {
                list.Add(this.Map(consultant));
            }

            return list;
        }

        public ListViewModel MapList(IList<Consultant> consultants)
        {
            var viewModel = new ListViewModel();

            viewModel.Consultants = this.MapMultiple(consultants);
            
            return viewModel;
        }
    }
}
