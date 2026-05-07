using ReservaHotelTipi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReservaHotelTipi.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.Client;

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();


        
    }
}
