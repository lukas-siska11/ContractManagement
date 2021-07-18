namespace ContractManagement.Domain.Specifications.Contracts
{
    public class ContractSpecification : AbstractSpecification
    {
        public int InstitutionID { get; set; }

        public int ClientID { get; set; }

        public int AdministratorID { get; set; }
    }
}
