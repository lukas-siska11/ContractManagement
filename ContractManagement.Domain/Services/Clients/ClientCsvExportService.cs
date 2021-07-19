using ContractManagement.Domain.Repositories.Clients;
using ContractManagement.Domain.Services.Export;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Services.Clients
{
    public class ClientCsvExportService : AbstractCsvExportService<ClientCsvRow>
    {
        private readonly IClientRepository clientRepository;

        public ClientCsvExportService(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        protected override string GetFilename()
        {
            return $"client_export_{DateTime.UtcNow.Ticks}.csv";
        }

        protected async override Task<IList<ClientCsvRow>> GetRecords()
        {
            var clients = await this.clientRepository.FindAll();
            var rows = new List<ClientCsvRow>();

            foreach (var client in clients)
            {
                rows.Add(new ClientCsvRow()
                {
                    Name = client.Name,
                    Surname = client.Surname,
                    Email = client.Email,
                    Phone = client.Phone,
                    Age = client.Age,
                    PersonalIdentificationNumber = client.PersonalIdentificationNumber
                });
            }

            return rows;
        }
    }
}
