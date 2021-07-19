using ContractManagement.Application.Mappers.Consultants;
using ContractManagement.Application.ViewModels.Consultants;
using ContractManagement.Domain.Repositories.Consultants;
using ContractManagement.Domain.Services.Consultants;
using ContractManagement.Domain.Services.Export;
using ContractManagement.Domain.Specifications.Consultants;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Consultants
{
    public class ConsultantApplicationService : IConsultantApplicationService
    {
        private readonly IConsultantRepository consultantRepository;
        private readonly ConsultantMapper consultantMapper;
        private readonly ConsultantCsvExportService consultantCsvExportService;

        public ConsultantApplicationService(
            IConsultantRepository consultantRepository,
            ConsultantMapper consultantMapper,
            ConsultantCsvExportService consultantCsvExportService
        )
        {
            this.consultantRepository = consultantRepository;
            this.consultantMapper = consultantMapper;
            this.consultantCsvExportService = consultantCsvExportService;
        }

        public async Task<ConsultantViewModel> GetConsultantViewModel(int id)
        {
            var consultant = await this.consultantRepository.FindById(id);
            if (consultant == null)
            {
                throw new Exception("Consultant with ID: " + id + " not found");
            }

            return this.consultantMapper.Map(consultant);
        }

        public async Task<ListViewModel> GetListViewModel()
        {
            var consultants = await this.consultantRepository.FindAll();
            return this.consultantMapper.MapList(consultants);
        }

        public async Task<ListViewModel> GetListViewModel(HttpRequest request)
        {
            var consultants = await this.consultantRepository.FindAll(this.PrepareSpecificationFromRequest(request));
            var listViewModel = this.consultantMapper.MapList(consultants);

            listViewModel.Search = request.Query["Search"].ToString();

            return listViewModel;
        }

        public async Task<CsvExportResult> GetCsvExportResult()
        {
            return await this.consultantCsvExportService.Export();
        }

        protected ConsultantSpecification PrepareSpecificationFromRequest(HttpRequest request)
        {
            var specification = new ConsultantSpecification();

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
