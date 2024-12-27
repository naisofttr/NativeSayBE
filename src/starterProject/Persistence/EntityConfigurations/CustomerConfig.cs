
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> entity)
    {
        entity.ToTable("customer").HasKey(u => u.Id);
        entity.Property(u => u.Id).HasColumnName("Id").IsRequired();

        entity.Property(e => e.RecId)
            .ValueGeneratedOnAdd()
            .IsRequired()
            .HasColumnName("Recid");
    }
}