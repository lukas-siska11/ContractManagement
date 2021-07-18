using ContractManagement.Domain.Entities.Clients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractManagement.Infrastructure.Data.Configurations.Clients
{
    class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");

            builder.Property(contract => contract.ID)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(contract => contract.Name)
                   .IsRequired();

            builder.Property(contract => contract.Surname)
                   .IsRequired();

            builder.Property(contract => contract.Email)
                   .IsRequired();

            builder.Property(contract => contract.Phone)
                   .IsRequired();

            builder.Property(contract => contract.Age)
                   .IsRequired();

            builder.Property(contract => contract.PersonalIdentificationNumber)
                   .IsRequired();

            builder.Property(contract => contract.CreatedDate)
                   .IsRequired()
                   .ValueGeneratedOnAdd();
        }
    }
}
