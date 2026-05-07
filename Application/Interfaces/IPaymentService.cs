using Application.DTOs.Payments;
using Application.DTOs.Reservations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentResponseDto> CreatePaymentAsync(CreatePaymentDto dto);
        Task<List<PaymentResponseDto>> GetByReservationIdAsync(int reservationId);

    }
}
