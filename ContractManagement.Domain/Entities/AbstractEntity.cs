using System;

namespace ContractManagement.Domain.Entities
{
    public abstract class AbstractEntity : IEntity
    {
        public int ID { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
