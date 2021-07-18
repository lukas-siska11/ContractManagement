using ContractManagement.Application.Mappers.Consultants;
using ContractManagement.Application.ViewModels.Consultants;
using ContractManagement.Domain.Repositories.Consultants;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ContractManagement.Application.ApplicationServices.Consultants
{
    public class ConsultantApplicationService : IConsultantApplicationService
    {
        private readonly IConsultantRepository consultantRepository;
        private readonly ConsultantMapper consultantMapper;

        public ConsultantApplicationService(IConsultantRepository consultantRepository, ConsultantMapper consultantMapper)
        {
            this.consultantRepository = consultantRepository;
            this.consultantMapper = consultantMapper;
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
            var consultants = await this.consultantRepository.FindAll();
            return this.consultantMapper.MapList(consultants);
        }
    }
}
