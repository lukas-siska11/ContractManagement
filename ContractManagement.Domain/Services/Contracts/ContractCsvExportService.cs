using ContractManagement.Domain.Repositories.Contracts;
using ContractManagement.Domain.Services.Export;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Services.Contracts
{
    public class ContractCsvExportService : AbstractCsvExportService<ContractCsvRow>
    {
        private readonly IContractRepository contractRepository;

        public ContractCsvExportService(IContractRepository contractRepository)
        {
            this.contractRepository = contractRepository;
        }

        protected override string GetFilename()
        {
            return $"contract_export_{DateTime.UtcNow.Ticks}.csv";
        }

        protected async override Task<IList<ContractCsvRow>> GetRecords()
        {
            var contracts = await this.contractRepository.FindAll();
            var rows = new List<ContractCsvRow>();

            foreach (var contract in contracts)
            {
                rows.Add(new ContractCsvRow()
                {
                    RegistrationNumber = contract.RegistrationNumber,
                    Institution = contract.Institution.Name,
                    Client = contract.Client.Fullname,
                    Administrator = contract.Administrator.Fullname,
                    ConclusionDate = contract.ConclusionDate.ToString("dd/MM/yyyy"),
                    ValidFromDate = contract.ValidFromDate.ToString("dd/MM/yyyy"),
                    TerminationDate = contract.TerminationDate.ToString("dd/MM/yyyy")
                });
            }

            return rows;
        }
    }
}
