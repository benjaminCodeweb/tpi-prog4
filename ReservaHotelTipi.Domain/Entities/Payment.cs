using ReservaHotelTipi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReservaHotelTipi.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }

        public PaymentMethod Method { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;

        public Reservation? Reservation { get; set; }
    }
}
