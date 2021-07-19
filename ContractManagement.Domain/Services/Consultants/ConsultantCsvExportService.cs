using ContractManagement.Domain.Repositories.Consultants;
using ContractManagement.Domain.Services.Export;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Services.Consultants
{
    public class ConsultantCsvExportService : AbstractCsvExportService<ConsultantCsvRow>
    {
        private readonly IConsultantRepository consultantRepository;

        public ConsultantCsvExportService(IConsultantRepository consultantRepository)
        {
            this.consultantRepository = consultantRepository;
        }

        protected override string GetFilename()
        {
            return $"consultant_export_{DateTime.UtcNow.Ticks}.csv";
        }

        protected async override Task<IList<ConsultantCsvRow>> GetRecords()
        {
            var consultants = await this.consultantRepository.FindAll();
            var rows = new List<ConsultantCsvRow>();

            foreach (var consultant in consultants)
            {
                rows.Add(new ConsultantCsvRow()
                {
                    Name = consultant.Name,
                    Surname = consultant.Surname,
                    Email = consultant.Email,
                    Phone = consultant.Phone,
                    Age = consultant.Age,
                    PersonalIdentificationNumber = consultant.PersonalIdentificationNumber
                });
            }

            return rows;
        }
    }
}
