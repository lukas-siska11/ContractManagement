namespace ContractManagement.Domain.Specifications
{
    // Provides basic properties for specification
    // Records will be filtered based on these specifications
    public abstract class AbstractSpecification
    {
        public int Page { get; set; } = 1;

        public int Limit { get; set; } = 7;

        public string Search { get; set; }
    }
}
