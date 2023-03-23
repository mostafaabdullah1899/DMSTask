using DMSTask.Models;
using System;
using System.Collections.Generic;

namespace DMSTask.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Appointment> Appointments { get; set; }
    }

}

