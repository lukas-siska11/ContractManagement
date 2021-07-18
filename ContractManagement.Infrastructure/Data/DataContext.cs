using ContractManagement.Domain.Entities.Clients;
using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Entities.Contracts;
using ContractManagement.Domain.Entities.Institutions;
using ContractManagement.Infrastructure.Data.Configurations.Clients;
using ContractManagement.Infrastructure.Data.Configurations.Consultants;
using ContractManagement.Infrastructure.Data.Configurations.Contracts;
using ContractManagement.Infrastructure.Data.Configurations.Institutions;
using Microsoft.EntityFrameworkCore;

namespace ContractManagement.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Consultant> Consultants { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Institution> Institutions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new ConsultantConfiguration());
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new InstitutionConfiguration());
        }
    }
}
