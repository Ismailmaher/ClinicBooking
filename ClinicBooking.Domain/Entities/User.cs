using ClinicBooking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicBooking.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Email { get; set; }= string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; }


        public Doctor? Doctor { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
