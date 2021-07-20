using ContractManagement.Domain.Entities.Consultants;

namespace ContractManagement.Domain.Entities.Contracts
{
    public class ContractConsultants
    {
        public Contract Contract { get; set; }

        public int ContractID { get; set; }

        public Consultant Consultant { get; set; }

        public int ConsultantID { get; set; }
    }
}
