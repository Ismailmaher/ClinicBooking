using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicBooking.Domain.Entities
{
    public class DoctorSchedule
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int DayOfWeek { get; set; } 
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int SlotDurationInMinutes { get; set; }

        public Doctor Doctor { get; set; } = null!;
    }
}
