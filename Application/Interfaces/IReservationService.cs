using Application.DTOs.Reservations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IReservationService
    {

        Task<ReservationResponseDto> CreateReservationAsync(CreateReservationDto dto);
        Task<List<ReservationResponseDto>> GetAllAsync();

        Task<ReservationResponseDto> GetByIdAsync(int id);
        Task<List<ReservationResponseDto>> GetByUserIdAsync(int userId);

        Task<bool> CancelByIdAsync(int id, int userId);







    }
}
