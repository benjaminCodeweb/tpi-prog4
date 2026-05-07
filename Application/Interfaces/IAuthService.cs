using Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IAuthService
    {
        Task<UserResponseDto> RegisterAsync(RegisterUserDto dto);
        Task<UserResponseDto> LoginAsync(LoginUserDto dto);
    }
}
