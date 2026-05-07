using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Payments
{
    public class CreatePaymentDto
    {
        public int ReservationId { get; set; }

        public string Method { get; set; } = string.Empty;

        public decimal Amount { get; set; }
    }
}
