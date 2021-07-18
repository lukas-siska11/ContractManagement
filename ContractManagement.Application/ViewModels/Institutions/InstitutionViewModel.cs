using System.ComponentModel.DataAnnotations;

namespace ContractManagement.Application.ViewModels.Institutions
{
    public class InstitutionViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Název")]
        public string Name { get; set; }
    }
}
