using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagement.Domain.Entities.Persons
{
    public class Person : AbstractEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        [NotMapped]
        public string Fullname { get { return this.Name + " " + this.Surname; } }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int Age { get; set; }

        public string PersonalIdentificationNumber { get; set; }
    }
}
