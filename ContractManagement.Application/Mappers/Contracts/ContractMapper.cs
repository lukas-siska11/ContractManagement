using ContractManagement.Application.Mappers.Clients;
using ContractManagement.Application.Mappers.Consultants;
using ContractManagement.Application.Mappers.Institutions;
using ContractManagement.Application.ViewModels.Contracts;
using ContractManagement.Domain.Entities.Clients;
using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Entities.Contracts;
using ContractManagement.Domain.Entities.Institutions;
using System.Collections.Generic;

namespace ContractManagement.Application.Mappers.Contracts
{
    public class ContractMapper
    {
        private readonly InstitutionMapper institutionMapper;
        private readonly ClientMapper clientMapper;
        private readonly ConsultantMapper consultantMapper;

        public ContractMapper(InstitutionMapper institutionMapper, ClientMapper clientMapper, ConsultantMapper consultantMapper)
        {
            this.institutionMapper = institutionMapper;
            this.clientMapper = clientMapper;
            this.consultantMapper = consultantMapper;
        }

        public ContractViewModel Map(Contract entity)
        {
            var viewModel = new ContractViewModel();

            viewModel.ID = entity.ID;
            viewModel.RegistrationNumber = entity.RegistrationNumber;
            viewModel.Institution = this.institutionMapper.Map(entity.Institution);
            viewModel.Client = this.clientMapper.Map(entity.Client);
            viewModel.Administrator = this.consultantMapper.Map(entity.Administrator);
            viewModel.ConclusionDate = entity.ConclusionDate;
            viewModel.ValidFromDate = entity.ValidFromDate;
            viewModel.TerminationDate = entity.TerminationDate;

            return viewModel;
        }

        public IList<ContractViewModel> MapMultiple(IList<Contract> contracts)
        {
            var list = new List<ContractViewModel>();
            foreach (var contract in contracts)
            {
                list.Add(this.Map(contract));
            }

            return list;
        }

        public ListViewModel MapList(IList<Contract> contracts, IList<Client> clients, IList<Consultant> administrators, IList<Institution> institutions)
        {
            var viewModel = new ListViewModel();

            viewModel.Administrators = this.consultantMapper.MapMultiple(administrators);
            viewModel.Clients = this.clientMapper.MapMultiple(clients);
            viewModel.Contracts = this.MapMultiple(contracts);
            viewModel.Institutions = this.institutionMapper.MapMultiple(institutions);

            return viewModel;
        }
    }
}
