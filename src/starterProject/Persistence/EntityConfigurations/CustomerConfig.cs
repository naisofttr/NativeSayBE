
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> entity)
    {
        entity.ToTable("customer");

        entity.HasKey(e => e.RecId)
            .HasName("customer_pkey");

        entity.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        entity.Property(e => e.RecId)
            .HasColumnName("recid")
            .HasDefaultValueSql("uuid_generate_v1()");

        entity.Property(u => u.Id).HasColumnName("Id").IsRequired();
        entity.Property(u => u.IdToken).HasColumnName("IdToken").IsRequired();
        entity.Property(u => u.Email).HasColumnName("Email").IsRequired();
        entity.Property(u => u.Name).HasColumnName("Name").IsRequired();
        entity.Property(u => u.ProfilePhotoUrl).HasColumnName("ProfilePhotoUrl").IsRequired();
        entity.Property(u => u.CreatedDate).HasColumnName("CreatedDate").IsRequired();
    }

}