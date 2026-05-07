using ReservaHotelTipi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReservaHotelTipi.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RoomId { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int GuestsCount { get; set; }

        public decimal Subtotal { get; set; }

        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        public User? User { get; set; }

        public Room? Room { get; set; }

        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
