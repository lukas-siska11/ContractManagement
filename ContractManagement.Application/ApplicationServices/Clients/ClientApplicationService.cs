using ContractManagement.Application.Mappers.Clients;
using ContractManagement.Application.ViewModels.Clients;
using ContractManagement.Domain.Repositories.Clients;
using ContractManagement.Domain.Services.Clients;
using ContractManagement.Domain.Services.Export;
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
        private readonly ClientCsvExportService clientCsvExportService;

        public ClientApplicationService(
            IClientRepository clientRepository,
            ClientMapper clientMapper,
            ClientCsvExportService clientCsvExportService
        )
        {
            this.clientRepository = clientRepository;
            this.clientMapper = clientMapper;
            this.clientCsvExportService = clientCsvExportService;
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
            var clients = await this.clientRepository.FindAll(this.PrepareSpecificationFromRequest(request));
            var listViewModel = this.clientMapper.MapList(clients);

            listViewModel.Search = request.Query["Search"].ToString();

            return listViewModel;
        }

        public async Task<ListViewModel> GetListViewModel()
        {
            var clients = await this.clientRepository.FindAll();
            return this.clientMapper.MapList(clients);
        }

        public async Task<CsvExportResult> GetCsvExportResult()
        {
            return await this.clientCsvExportService.Export();
        }

        protected ClientSpecification PrepareSpecificationFromRequest(HttpRequest request)
        {
            var specification = new ClientSpecification();

            // TODO: Move to separate class?
            specification.Page = (request.Query["Page"].ToString() != "")
                ? Convert.ToInt32(request.Query["Page"])
                : specification.Page;

            specification.Limit = (request.Query["Limit"].ToString() != "")
                ? Convert.ToInt32(request.Query["Limit"])
                : specification.Limit;

            specification.Search = request.Query["Search"];

            return specification;
        }
    }
}
