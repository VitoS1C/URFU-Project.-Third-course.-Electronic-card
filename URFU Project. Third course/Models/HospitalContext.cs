using Microsoft.EntityFrameworkCore;

namespace URFU_Project._Third_course.Models
{
    internal class HospitalContext : DbContext
    {
        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Doctor>? Doctors { get; set; }
        public DbSet<OutpatientСard>? Cards { get; set; }
        public DbSet<User>? Users { get; set; }

        public HospitalContext()
        {
            Database.EnsureCreatedAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hospital.db");
        }
    }
}
