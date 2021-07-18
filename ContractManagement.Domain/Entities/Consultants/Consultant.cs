using ContractManagement.Domain.Entities.Contracts;
using ContractManagement.Domain.Entities.Persons;
using System.Collections.Generic;

namespace ContractManagement.Domain.Entities.Consultants
{
    public class Consultant : Person
    {
        public ICollection<Contract> Contracts { get; set; }
    }
}
