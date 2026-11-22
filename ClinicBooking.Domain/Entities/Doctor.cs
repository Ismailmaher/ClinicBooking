using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicBooking.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SpecialtyId { get; set; }        
        public string? Bio { get; set; }
        public decimal ConsultationFee { get; set; }

        public Specialty Specialty { get; set; } = null!;
        public User User { get; set; } = null!;
        public ICollection<DoctorSchedule> Schedules { get; set; } = new List<DoctorSchedule>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
