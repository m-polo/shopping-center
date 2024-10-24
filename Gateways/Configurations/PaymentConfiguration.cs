using System;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Repositories.Configurations
{
	public class PaymentConfiguration :
            IEntityTypeConfiguration<Payment>
    {

        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(o => o.Amount)
                .IsRequired()
                .HasPrecision(8, 2);

            builder.Property(o => o.Currency)
                .IsRequired()
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(o => o.Status)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(o => o.OrderId)
                .IsRequired();
        }
    }
}

