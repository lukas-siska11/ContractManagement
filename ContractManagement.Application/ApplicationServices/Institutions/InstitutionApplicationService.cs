using ContractManagement.Application.Mappers.Institutions;
using ContractManagement.Application.ViewModels.Institutions;
using ContractManagement.Domain.Repositories.Institutions;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Institutions
{
    public class InstitutionApplicationService : IInstitutionApplicationService
    {
        private readonly IInstitutionRepository institutionRepository;
        private readonly InstitutionMapper institutionMapper;

        public InstitutionApplicationService(IInstitutionRepository institutionRepository, InstitutionMapper institutionMapper)
        {
            this.institutionRepository = institutionRepository;
            this.institutionMapper = institutionMapper;
        }

        public async Task<InstitutionViewModel> GetInstitutionViewModel(int id)
        {
            var institution = await this.institutionRepository.FindById(id);
            if (institution == null)
            {
                throw new Exception("Institution with ID: " + id + " not found");
            }

            return this.institutionMapper.Map(institution);
        }

        public async Task<ListViewModel> GetListViewModel()
        {
            var institutions = await this.institutionRepository.FindAll();
            return this.institutionMapper.MapList(institutions);
        }

        public async Task<ListViewModel> GetListViewModel(HttpRequest request)
        {
            var institutions = await this.institutionRepository.FindAll();
            return this.institutionMapper.MapList(institutions);
        }
    }
}
