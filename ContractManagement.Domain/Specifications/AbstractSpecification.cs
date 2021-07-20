namespace ContractManagement.Domain.Specifications
{
    public abstract class AbstractSpecification
    {
        public int Page { get; set; } = 1;

        public int Limit { get; set; } = 10;

        public string Search { get; set; }
    }
}
