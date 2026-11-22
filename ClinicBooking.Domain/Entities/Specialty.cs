using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicBooking.Domain.Entities
{
    public class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
