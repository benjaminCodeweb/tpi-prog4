using Application.DTOs.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IRoomService
    {
        Task<RoomResponseDto> CreateRoomAsync (CreateRoomDto dto);
        Task<List<RoomResponseDto>> GetAllAsync();

        Task<RoomResponseDto> GetByIdAsync(int id);
    }
}
