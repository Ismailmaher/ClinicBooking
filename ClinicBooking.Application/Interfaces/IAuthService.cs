using System;
using System.Collections.Generic;
using System.Text;

using ClinicBooking.Application.DTOs.Auth;

namespace ClinicBooking.Application.Interfaces;

public interface IAuthService
{
    Task<AuthResponse> RegisterAsync(RegisterRequest request);
    Task<AuthResponse> LoginAsync(LoginRequest request);
}