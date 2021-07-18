using ContractManagement.Domain.Entities.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContractManagement.Infrastructure.Data.Configurations.Contracts
{
    class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contracts");

            builder.Property(contract => contract.ID)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(contract => contract.RegistrationNumber)
                   .IsRequired();

            builder.HasOne(contract => contract.Institution)
                   .WithMany()
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();

            builder.HasOne(contract => contract.Client)
                   .WithMany()
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();

            builder.HasOne(contract => contract.Administrator)
                   .WithMany()
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();

            builder.Property(contract => contract.ConclusionDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(contract => contract.ValidFromDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(contract => contract.TerminationDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(contract => contract.CreatedDate)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.HasMany(contract => contract.Consultants)
                   .WithMany(consultant => consultant.Contracts)
                   .UsingEntity(join => join.ToTable("ContractConsultants"));
        }
    }
}
