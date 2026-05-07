using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Rooms
{
    public class CreateRoomDto
    {
        public string Type { get; set; } = string.Empty;

        public decimal PricePerNight { get; set; }

        public int Capacity { get; set; }

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
