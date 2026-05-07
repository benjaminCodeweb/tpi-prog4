using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservaHotelTipi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastrcture.Configuration;

    public class ReservationConfiguration: IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("reservations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CheckInDate)
                .IsRequired();

            builder.Property(x => x.CheckOutDate)
                .IsRequired();

            builder.Property(x => x.GuestsCount)
                .IsRequired();

            builder.Property(x => x.Subtotal)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(x => x.Status)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Reservations)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Room)
                .WithMany(x => x.Reservations)
                .HasForeignKey(x => x.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Payments)
                .WithOne(x => x.Reservation)
                .HasForeignKey(x => x.ReservationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

