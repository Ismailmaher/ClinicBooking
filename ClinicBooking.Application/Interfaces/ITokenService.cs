using System;
using System.Collections.Generic;
using System.Text;
using ClinicBooking.Domain.Entities;

namespace ClinicBooking.Application.Interfaces;

public interface ITokenService
{
    string GenerateToken(User user);
}