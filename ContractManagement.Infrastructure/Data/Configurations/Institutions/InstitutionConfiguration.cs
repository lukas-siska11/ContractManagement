using ContractManagement.Domain.Entities.Institutions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractManagement.Infrastructure.Data.Configurations.Institutions
{
    class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
    {
        public void Configure(EntityTypeBuilder<Institution> builder)
        {
            builder.ToTable("Institutions");

            builder.Property(institution => institution.ID)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(institution => institution.Name)
                   .IsRequired();

            builder.Property(contract => contract.CreatedDate)
                   .IsRequired()
                   .ValueGeneratedOnAdd();
        }
    }
}
