using MVCEFwebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCEFwebApp.Models
{
    public class HospitalDbContext:DbContext

    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            String connString = @"server=200411LTP2714\SQLEXPRESS;database=HospitalDB;integrated security=true;Encrypt=false";
            options.UseSqlServer(connString);
        }



    }
}
