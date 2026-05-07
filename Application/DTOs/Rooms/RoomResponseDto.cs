using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Rooms
{
    public class RoomResponseDto
    {
        public int Id { get; set; }

        public string Type { get; set; } = string.Empty;

        public decimal PricePerNight { get; set; }

        public int Capacity { get; set; }

        public string Status { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
