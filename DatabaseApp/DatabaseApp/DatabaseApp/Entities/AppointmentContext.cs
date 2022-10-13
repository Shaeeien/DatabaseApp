using DatabaseApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DatabaseApp.Entities
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext()
        {

        }

        public AppointmentContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-EII9684; Database = Appointments; Trusted_Connection = true; TrustServerCertificate=True; MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Doctor>(eb =>
            {
                eb.Property(x => x.Id).IsRequired();
                eb.Property(x => x.Cabinet_number).IsRequired();
                eb.HasMany(x => x.Patients).WithMany(x => x.Doctors).UsingEntity<Appointment>(
                    d => d.HasOne(a => a.Patient).WithMany().HasForeignKey(d => d.PatientId),
                    d => d.HasOne(a => a.Doctor).WithMany().HasForeignKey(d => d.DoctorId),
                    d =>
                    {
                        d.HasKey(d => new { d.DoctorId, d.PatientId });
                        d.Property(x => x.Time).HasDefaultValueSql("getutcdate()");
                    }); 
            });

            builder.Entity<Patient>(eb =>
            {
                eb.Property(x => x.Id).IsRequired();                
            });

            builder.Entity<Appointment>(eb =>
            {
                eb.Property(x => x.AppointmentId).IsRequired();
                eb.Property(x => x.DoctorId).IsRequired();
                eb.Property(x => x.PatientId).IsRequired();

            });
            builder.Entity<AppUser>(eb => {
                eb.Property(x => x.Id).IsRequired();
                eb.Property(x => x.Login).IsRequired();
                eb.Property(x => x.Password).IsRequired();

            });
            
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
