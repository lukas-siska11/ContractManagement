using ContractManagement.Domain.Entities.Clients;
using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Entities.Institutions;
using System;
using System.Collections.Generic;

namespace ContractManagement.Domain.Entities.Contracts
{
    public class Contract : AbstractEntity
    {
        public string RegistrationNumber { get; set; }

        public Institution Institution { get; set; }

        public int InstitutionID { get; set; }

        public Client Client { get; set; }

        public int ClientID { get; set; }

        public Consultant Administrator { get; set; }

        public int AdministratorID { get; set; }

        public DateTime ConclusionDate { get; set; }

        public DateTime ValidFromDate { get; set; }

        public DateTime TerminationDate { get; set; }

        public IList<Consultant> Consultants { get; set; }
    }
}
