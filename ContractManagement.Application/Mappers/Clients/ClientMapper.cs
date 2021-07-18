using ContractManagement.Application.ViewModels.Clients;
using ContractManagement.Domain.Entities.Clients;
using System.Collections.Generic;

namespace ContractManagement.Application.Mappers.Clients
{
    public class ClientMapper
    {
        public ClientViewModel Map(Client entity)
        {
            var viewModel = new ClientViewModel();

            viewModel.ID = entity.ID;
            viewModel.Name = entity.Name;
            viewModel.Surname = entity.Surname;
            viewModel.Email = entity.Email;
            viewModel.Phone = entity.Phone;
            viewModel.Age = entity.Age;
            viewModel.PersonalIdentificationNumber = entity.PersonalIdentificationNumber;

            return viewModel;
        }

        public IList<ClientViewModel> MapMultiple(IList<Client> clients)
        {
            var list = new List<ClientViewModel>();
            foreach (var client in clients)
            {
                list.Add(this.Map(client));
            }

            return list;
        }

        public ListViewModel MapList(IList<Client> clients)
        {
            var viewModel = new ListViewModel();

            viewModel.Clients = this.MapMultiple(clients);
            
            return viewModel;
        }
    }
}
