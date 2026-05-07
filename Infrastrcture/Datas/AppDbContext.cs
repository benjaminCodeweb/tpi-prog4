using Microsoft.EntityFrameworkCore;
using ReservaHotelTipi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastrcture.Datas
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Room> Rooms => Set<Room>();

        public DbSet<Reservation> Reservations => Set<Reservation>();

        public DbSet<Payment> Payments => Set<Payment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
