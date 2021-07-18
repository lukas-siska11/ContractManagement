using ContractManagement.Application.Mappers.Clients;
using ContractManagement.Application.ViewModels.Clients;
using ContractManagement.Domain.Repositories.Clients;
using ContractManagement.Domain.Specifications.Clients;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Clients
{
    public class ClientApplicationService : IClientApplicationService
    {
        private readonly IClientRepository clientRepository;
        private readonly ClientMapper clientMapper;

        public ClientApplicationService(IClientRepository clientRepository, ClientMapper clientMapper)
        {
            this.clientRepository = clientRepository;
            this.clientMapper = clientMapper;
        }

        public async Task<ClientViewModel> GetClientViewModel(int id)
        {
            var client = await this.clientRepository.FindById(id);
            if (client == null)
            {
                throw new Exception("Client with ID: " + id + " not found");
            }

            return this.clientMapper.Map(client);
        }

        public async Task<ListViewModel> GetListViewModel(HttpRequest request)
        {
            ClientSpecification specification = new ClientSpecification();
            if (request.Query["page"].ToString() != "")
            {
                specification.Page = Convert.ToInt32(request.Query["page"]);
            }

            if (request.Query["limit"].ToString() != "")
            {
                specification.Limit = Convert.ToInt32(request.Query["limit"]);
            }

            specification.Search = request.Query["search"];

            var clients = await this.clientRepository.FindAll(specification);
            return this.clientMapper.MapList(clients);
        }

        public async Task<ListViewModel> GetListViewModel()
        {
            var clients = await this.clientRepository.FindAll();
            return this.clientMapper.MapList(clients);
        }
    }
}
