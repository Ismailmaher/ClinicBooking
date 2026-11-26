using System;
using System.Collections.Generic;
using System.Text;
using ClinicBooking.Application.DTOs.Auth;
using ClinicBooking.Application.Interfaces;
using ClinicBooking.Domain.Entities;
using ClinicBooking.Domain.Enums;
using ClinicBooking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ClinicBooking.Infrastructure.Services;

public class AuthService : IAuthService
{
    private readonly AppDbContext _context;
    private readonly ITokenService _tokenService;

    public AuthService(AppDbContext context, ITokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    public async Task<AuthResponse> RegisterAsync(RegisterRequest request)
    {
        var email = request.Email.Trim().ToLower();

        var exists = await _context.Users.AnyAsync(u => u.Email == email);
        if (exists)
            throw new InvalidOperationException("Email is already registered.");

        var user = new User
        {
            Name = request.Name.Trim(),
            Email = email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
            Role = UserRole.Patient
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return new AuthResponse
        {
            Token = _tokenService.GenerateToken(user),
            Name = user.Name,
            Email = user.Email,
            Role = user.Role.ToString()
        };
    }

    public Task<AuthResponse> LoginAsync(LoginRequest request)
    {
        throw new NotImplementedException();
    }
}