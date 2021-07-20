namespace ContractManagement.Domain.Services.Person
{
    // Represents one row in CSV file with person properties
    public class PersonCsvRow
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int Age { get; set; }

        public string PersonalIdentificationNumber { get; set; }
    }
}
