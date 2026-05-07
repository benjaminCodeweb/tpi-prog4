using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Reservations
{
    public class CreateReservationDto
    {
        public int RoomId { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int GuestsCount { get; set; }
    }
}
