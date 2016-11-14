using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.DataModel;

namespace MS.ServiceHost
{
    public class MedicSchedulerContext : DbContext
    {
       
        public MedicSchedulerContext()
            :base("MSConnection")
        { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Speciality> Specialties { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
