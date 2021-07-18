using ContractManagement.Application.ViewModels.Clients;
using ContractManagement.Application.ViewModels.Consultants;
using ContractManagement.Application.ViewModels.Institutions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContractManagement.Application.ViewModels.Contracts
{
    public class ContractViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Registrační číslo")]
        public string RegistrationNumber { get; set; }

        [Required]
        [Display(Name = "Instituce")]
        public InstitutionViewModel Institution { get; set; }

        [Required]
        [Display(Name = "Klient")]
        public ClientViewModel Client { get; set; }

        [Required]
        [Display(Name = "Správce")]
        public ConsultantViewModel Administrator { get; set; }

        [Required]
        [Display(Name = "Datum uzavření")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ConclusionDate { get; set; }

        [Required]
        [Display(Name = "Datum platnosti")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ValidFromDate { get; set; }

        [Required]
        [Display(Name = "Datum ukončení")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TerminationDate { get; set; }

        [Display(Name = "Účastníci")]
        public ICollection<ConsultantViewModel> Consultants { get; set; }
    }
}
