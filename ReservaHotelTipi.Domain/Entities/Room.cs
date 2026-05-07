using ReservaHotelTipi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReservaHotelTipi.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }

        public RoomType Type { get; set; }

        public decimal PricePerNight { get; set; }

        public int Capacity { get; set; }

        public RoomStatus Status { get; set; } = RoomStatus.Available;

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
