using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Principal;

namespace DMSTask.Models
{
    public class ClinicContext : DbContext
    {
        public ClinicContext() : base()
        {

        }
        public ClinicContext(DbContextOptions<ClinicContext> options) : base()
        {

        }
        //public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
        //    : base(options)
        //{
        //}

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-C53EFCM;Initial Catalog=DMSTask;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
