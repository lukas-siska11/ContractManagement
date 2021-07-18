using System.ComponentModel.DataAnnotations;

namespace ContractManagement.Application.ViewModels.Person
{
    public class PersonViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Jméno")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Příjmení")]
        public string Surname { get; set; }

        public string FullName { get { return Name + " " + Surname; } }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Věk")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Rodné číslo")]
        public string PersonalIdentificationNumber { get; set; }
    }
}
