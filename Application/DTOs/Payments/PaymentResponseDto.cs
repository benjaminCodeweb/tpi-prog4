using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Payments
{
    public class PaymentResponseDto
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }

        public string Method { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}
