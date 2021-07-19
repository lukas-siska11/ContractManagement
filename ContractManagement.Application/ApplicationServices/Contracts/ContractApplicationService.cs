using ContractManagement.Application.Mappers.Contracts;
using ContractManagement.Application.ViewModels.Contracts;
using ContractManagement.Domain.Repositories.Clients;
using ContractManagement.Domain.Repositories.Consultants;
using ContractManagement.Domain.Repositories.Contracts;
using ContractManagement.Domain.Repositories.Institutions;
using ContractManagement.Domain.Services.Contracts;
using ContractManagement.Domain.Services.Export;
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
        private readonly ContractCsvExportService contractCsvExportService;

        public ContractApplicationService(
            IClientRepository clientRepository,
            IConsultantRepository consultantRepository,
            IContractRepository contractRepository,
            IInstitutionRepository institutionRepository,
            ContractMapper contractMapper,
            ContractCsvExportService contractCsvExportService
        )
        {
            this.clientRepository = clientRepository;
            this.consultantRepository = consultantRepository;
            this.contractRepository = contractRepository;
            this.institutionRepository = institutionRepository;
            this.contractMapper = contractMapper;
            this.contractCsvExportService = contractCsvExportService;
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
            var administrators = await this.consultantRepository.FindAll();
            var clients = await this.clientRepository.FindAll();
            var contracts = await this.contractRepository.FindAll(this.PrepareSpecificationFromRequest(request));
            var institutions = await this.institutionRepository.FindAll();

            var listViewModel = this.contractMapper.MapList(contracts, clients, administrators, institutions);

            listViewModel.InstitutionId = request.Query["InstitutionId"].ToString();
            listViewModel.ClientId = request.Query["ClientId"].ToString();
            listViewModel.AdministratorId = request.Query["AdministratorId"].ToString();
            listViewModel.Search = request.Query["Search"].ToString();

            return listViewModel;
        }

        public async Task<ListViewModel> GetListViewModel()
        {
            var contracts = await this.contractRepository.FindAll();
            return this.contractMapper.MapList(contracts, null, null, null);
        }

        public async Task<CsvExportResult> GetCsvExportResult()
        {
            return await this.contractCsvExportService.Export();
        }

        protected ContractSpecification PrepareSpecificationFromRequest(HttpRequest request)
        {
            var specification = new ContractSpecification();

            // TODO: Move to separate class?
            specification.Page = (request.Query["Page"].ToString() != "")
                ? Convert.ToInt32(request.Query["Page"])
                : specification.Page;

            specification.Limit = (request.Query["Limit"].ToString() != "")
                ? Convert.ToInt32(request.Query["Limit"])
                : specification.Limit;

            specification.Search = request.Query["Search"];

            specification.InstitutionID = (request.Query["InstitutionId"].ToString() != "")
                ? Convert.ToInt32(request.Query["InstitutionId"])
                : (int?)null;

            specification.ClientID = (request.Query["clientId"].ToString() != "")
                ? Convert.ToInt32(request.Query["clientId"])
                : (int?)null;

            specification.AdministratorID = (request.Query["administratorId"].ToString() != "")
                ? Convert.ToInt32(request.Query["administratorId"])
                : (int?)null;

            return specification;
        }
    }
}
