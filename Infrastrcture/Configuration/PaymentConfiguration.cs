using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservaHotelTipi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastrcture.Configuration
{
    public class PaymentConfiguration: IEntityTypeConfiguration<Payment>

    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("payments");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Method)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.Property(x => x.Amount)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.Status)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.HasOne(x => x.Reservation)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.ReservationId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
