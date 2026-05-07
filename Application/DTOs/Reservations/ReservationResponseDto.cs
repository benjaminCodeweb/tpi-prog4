using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Reservations
{
    public class ReservationResponseDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RoomId { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int GuestsCount { get; set; }

        public decimal Subtotal { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}
