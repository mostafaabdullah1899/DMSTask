using System.Collections.Generic;

namespace DMSTask.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        public List<Schedule> Schedule { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
