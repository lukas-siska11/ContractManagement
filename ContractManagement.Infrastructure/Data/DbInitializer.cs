using ContractManagement.Domain.Entities.Clients;
using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Entities.Contracts;
using ContractManagement.Domain.Entities.Institutions;
using Microsoft.EntityFrameworkCore;
using System;

namespace ContractManagement.Infrastructure.Data
{
    class DbInitializer
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            // Institutions
            modelBuilder.Entity<Institution>().HasData(
                new Institution { ID = 1, Name = "AEGON", CreatedDate = DateTime.Now },
                new Institution { ID = 2, Name = "Axa", CreatedDate = DateTime.Now },
                new Institution { ID = 3, Name = "ČSOB", CreatedDate = DateTime.Now }
            );

            // Clients
            modelBuilder.Entity<Client>().HasData(
                new Client { ID = 1, Name = "Jan", Surname = "Novák", Email = "novak@seznam.cz", Phone = "+420777888001", Age = 30, PersonalIdentificationNumber = "870928/1234", CreatedDate = DateTime.Now },
                new Client { ID = 2, Name = "Petr", Surname = "Pěkný", Email = "pekny@seznam.cz", Phone = "+420777888002", Age = 20, PersonalIdentificationNumber = "990728/4567", CreatedDate = DateTime.Now },
                new Client { ID = 3, Name = "Pavel", Surname = "Pospíšil", Email = "pospisil@gmail.com", Phone = "+420777888003", Age = 23, PersonalIdentificationNumber = "971020/8907", CreatedDate = DateTime.Now },
                new Client { ID = 4, Name = "Lukáš", Surname = "Doloman", Email = "doloman@seznam.cz", Phone = "+420777888004", Age = 33, PersonalIdentificationNumber = "781304/1234", CreatedDate = DateTime.Now },
                new Client { ID = 5, Name = "Jana", Surname = "Větrová", Email = "vetrova@email.cz", Phone = "+420777888005", Age = 50, PersonalIdentificationNumber = "890920/4456", CreatedDate = DateTime.Now },
                new Client { ID = 6, Name = "Michal", Surname = "Povědomý", Email = "povedomy@outlook.cz", Phone = "+420777888006", Age = 39, PersonalIdentificationNumber = "670608/7890", CreatedDate = DateTime.Now },
                new Client { ID = 7, Name = "Dana", Surname = "Usměvavá", Email = "usmevava@seznam.cz", Phone = "+420777888007", Age = 36, PersonalIdentificationNumber = "891313/6789", CreatedDate = DateTime.Now },
                new Client { ID = 8, Name = "Diana", Surname = "Nádherná", Email = "nadherna@seznam.cz", Phone = "+420777888008", Age = 23, PersonalIdentificationNumber = "900709/5677", CreatedDate = DateTime.Now },
                new Client { ID = 9, Name = "Věra", Surname = "Polná", Email = "polna@seznam.cz", Phone = "+420777888009", Age = 38, PersonalIdentificationNumber = "670309/6707", CreatedDate = DateTime.Now },
                new Client { ID = 10, Name = "Kristýna", Surname = "Tmavá", Email = "tmava@seznam.cz", Phone = "+420777888010", Age = 36, PersonalIdentificationNumber = "980909/9090", CreatedDate = DateTime.Now },
                new Client { ID = 11, Name = "Tomáš", Surname = "Sysel", Email = "sysel@gmail.com", Phone = "+420777888011", Age = 45, PersonalIdentificationNumber = "021809/7899", CreatedDate = DateTime.Now },
                new Client { ID = 12, Name = "Petr", Surname = "Rychlý", Email = "rychly@centrum.cz", Phone = "+420777888012", Age = 66, PersonalIdentificationNumber = "031516/5667", CreatedDate = DateTime.Now },
                new Client { ID = 13, Name = "Michal", Surname = "Schick", Email = "schic@seznam.cz", Phone = "+420777888013", Age = 47, PersonalIdentificationNumber = "900909/8009", CreatedDate = DateTime.Now },
                new Client { ID = 14, Name = "Martina", Surname = "Osmá", Email = "osma@seznam.cz", Phone = "+420777888014", Age = 34, PersonalIdentificationNumber = "890605/7558", CreatedDate = DateTime.Now },
                new Client { ID = 15, Name = "Martin", Surname = "Semerád", Email = "semerad@gmail.com", Phone = "+420777888015", Age = 47, PersonalIdentificationNumber = "990907/7899", CreatedDate = DateTime.Now },
                new Client { ID = 16, Name = "Jan", Surname = "Slimák", Email = "slima@seznam.cz", Phone = "+420777888016", Age = 35, PersonalIdentificationNumber = "880906/8880", CreatedDate = DateTime.Now },
                new Client { ID = 17, Name = "Filip", Surname = "Dočkal", Email = "dockal@seznam.cz", Phone = "+420777888017", Age = 45, PersonalIdentificationNumber = "760506/7878", CreatedDate = DateTime.Now },
                new Client { ID = 18, Name = "Roman", Surname = "Všetečný", Email = "vsetecny@seznam.cz", Phone = "+420777888018", Age = 78, PersonalIdentificationNumber = "870102/9902", CreatedDate = DateTime.Now },
                new Client { ID = 19, Name = "Pavel", Surname = "Náročný", Email = "narocny@seznam.cz", Phone = "+420777888019", Age = 20, PersonalIdentificationNumber = "901212/4829", CreatedDate = DateTime.Now },
                new Client { ID = 20, Name = "Petr", Surname = "Vyoral", Email = "vyoral@seznam.cz", Phone = "+420777888020", Age = 18, PersonalIdentificationNumber = "910708/9899", CreatedDate = DateTime.Now }
            );

            // Consultants
            modelBuilder.Entity<Consultant>().HasData(
                new Consultant { ID = 1, Name = "Jan", Surname = "Novák", Email = "novak@seznam.cz", Phone = "+420777888001", Age = 30, PersonalIdentificationNumber = "870928/1234", CreatedDate = DateTime.Now },
                new Consultant { ID = 2, Name = "Petr", Surname = "Pěkný", Email = "pekny@seznam.cz", Phone = "+420777888002", Age = 20, PersonalIdentificationNumber = "990728/4567", CreatedDate = DateTime.Now },
                new Consultant { ID = 3, Name = "Pavel", Surname = "Pospíšil", Email = "pospisil@gmail.com", Phone = "+420777888003", Age = 23, PersonalIdentificationNumber = "971020/8907", CreatedDate = DateTime.Now },
                new Consultant { ID = 4, Name = "Jan", Surname = "Slimák", Email = "slima@seznam.cz", Phone = "+420777888016", Age = 35, PersonalIdentificationNumber = "880906/8880", CreatedDate = DateTime.Now },
                new Consultant { ID = 5, Name = "Filip", Surname = "Dočkal", Email = "dockal@seznam.cz", Phone = "+420777888017", Age = 45, PersonalIdentificationNumber = "760506/7878", CreatedDate = DateTime.Now },
                new Consultant { ID = 6, Name = "Roman", Surname = "Všetečný", Email = "vsetecny@seznam.cz", Phone = "+420777888018", Age = 78, PersonalIdentificationNumber = "870102/9902", CreatedDate = DateTime.Now },
                new Consultant { ID = 7, Name = "Pavel", Surname = "Náročný", Email = "narocny@seznam.cz", Phone = "+420777888019", Age = 20, PersonalIdentificationNumber = "901212/4829", CreatedDate = DateTime.Now }
            );

            // Contracts
            modelBuilder.Entity<Contract>().HasData(
                new Contract { ID = 1, RegistrationNumber = "68768768", InstitutionID = 1, ClientID = 1, AdministratorID = 7, ConclusionDate = DateTime.Now, ValidFromDate = DateTime.Now, TerminationDate = DateTime.Now, CreatedDate = DateTime.Now },
                new Contract { ID = 2, RegistrationNumber = "34567899", InstitutionID = 2, ClientID = 2, AdministratorID = 6, ConclusionDate = DateTime.Now, ValidFromDate = DateTime.Now, TerminationDate = DateTime.Now, CreatedDate = DateTime.Now },
                new Contract { ID = 3, RegistrationNumber = "87964775", InstitutionID = 2, ClientID = 3, AdministratorID = 5, ConclusionDate = DateTime.Now, ValidFromDate = DateTime.Now, TerminationDate = DateTime.Now, CreatedDate = DateTime.Now },
                new Contract { ID = 4, RegistrationNumber = "98908054", InstitutionID = 1, ClientID = 4, AdministratorID = 4, ConclusionDate = DateTime.Now, ValidFromDate = DateTime.Now, TerminationDate = DateTime.Now, CreatedDate = DateTime.Now },
                new Contract { ID = 5, RegistrationNumber = "45786436", InstitutionID = 3, ClientID = 5, AdministratorID = 3, ConclusionDate = DateTime.Now, ValidFromDate = DateTime.Now, TerminationDate = DateTime.Now, CreatedDate = DateTime.Now },
                new Contract { ID = 6, RegistrationNumber = "68986545", InstitutionID = 1, ClientID = 6, AdministratorID = 2, ConclusionDate = DateTime.Now, ValidFromDate = DateTime.Now, TerminationDate = DateTime.Now, CreatedDate = DateTime.Now }
            );

            // ContractConsultants
            modelBuilder.Entity<ContractConsultants>().HasData(
                new ContractConsultants { ContractID = 1, ConsultantID = 7 },
                new ContractConsultants { ContractID = 1, ConsultantID = 6 },
                new ContractConsultants { ContractID = 1, ConsultantID = 5 },
                new ContractConsultants { ContractID = 2, ConsultantID = 6 },
                new ContractConsultants { ContractID = 2, ConsultantID = 3 },
                new ContractConsultants { ContractID = 3, ConsultantID = 5 },
                new ContractConsultants { ContractID = 4, ConsultantID = 4 },
                new ContractConsultants { ContractID = 4, ConsultantID = 3 },
                new ContractConsultants { ContractID = 4, ConsultantID = 2 },
                new ContractConsultants { ContractID = 4, ConsultantID = 1 },
                new ContractConsultants { ContractID = 5, ConsultantID = 3 },
                new ContractConsultants { ContractID = 5, ConsultantID = 7 },
                new ContractConsultants { ContractID = 6, ConsultantID = 2 },
                new ContractConsultants { ContractID = 6, ConsultantID = 1 },
                new ContractConsultants { ContractID = 6, ConsultantID = 6 }
            );
        }
    }
}
