using System.Collections.Generic;

namespace DMSTask.Models
{
    public class Clinic
    {
        public int ClinicId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
