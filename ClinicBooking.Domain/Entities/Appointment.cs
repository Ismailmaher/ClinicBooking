using ClinicBooking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicBooking.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
        public AppointmentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public Doctor Doctor { get; set; } = null!;
        public User Patient { get; set; } = null!;

    }
}
