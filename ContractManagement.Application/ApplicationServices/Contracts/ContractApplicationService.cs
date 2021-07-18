using ContractManagement.Application.Mappers.Contracts;
using ContractManagement.Application.ViewModels.Contracts;
using ContractManagement.Domain.Repositories.Clients;
using ContractManagement.Domain.Repositories.Consultants;
using ContractManagement.Domain.Repositories.Contracts;
using ContractManagement.Domain.Repositories.Institutions;
using ContractManagement.Domain.Specifications.Contracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Contracts
{
    public class ContractApplicationService : IContractApplicationService
    {
        private readonly IClientRepository clientRepository;
        private readonly IConsultantRepository consultantRepository;
        private readonly IContractRepository contractRepository;
        private readonly IInstitutionRepository institutionRepository;
        private readonly ContractMapper contractMapper;

        public ContractApplicationService(
            IClientRepository clientRepository,
            IConsultantRepository consultantRepository,
            IContractRepository contractRepository,
            IInstitutionRepository institutionRepository,
            ContractMapper contractMapper
        )
        {
            this.clientRepository = clientRepository;
            this.consultantRepository = consultantRepository;
            this.contractRepository = contractRepository;
            this.institutionRepository = institutionRepository;
            this.contractMapper = contractMapper;
        }

        public async Task<ContractViewModel> GetContractViewModel(int id)
        {
            var contract = await this.contractRepository.FindById(id);
            if (contract == null)
            {
                throw new Exception("Contract with ID: " + id + " not found");
            }

            return this.contractMapper.Map(contract);
        }

        public async Task<ListViewModel> GetListViewModel(HttpRequest request)
        {
            // TODO: Přesunout?
            ContractSpecification specification = new ContractSpecification();
            if (request.Query["page"].ToString() != "")
            {
                specification.Page = Convert.ToInt32(request.Query["page"]);
            }

            if (request.Query["limit"].ToString() != "")
            {
                specification.Limit = Convert.ToInt32(request.Query["limit"]);
            }

            specification.Search = request.Query["search"];
            specification.InstitutionID = Convert.ToInt32(request.Query["institutionId"]);
            specification.ClientID = Convert.ToInt32(request.Query["clientId"]);
            specification.AdministratorID = Convert.ToInt32(request.Query["administratorId"]);

            var administrators = await this.consultantRepository.FindAll();
            var clients = await this.clientRepository.FindAll();
            var contracts = await this.contractRepository.FindAll(specification);
            var institutions = await this.institutionRepository.FindAll();

            return this.contractMapper.MapList(contracts, clients, administrators, institutions);
        }

        public async Task<ListViewModel> GetListViewModel()
        {
            var contracts = await this.contractRepository.FindAll();
            return this.contractMapper.MapList(contracts, null, null, null);
        }
    }
}
