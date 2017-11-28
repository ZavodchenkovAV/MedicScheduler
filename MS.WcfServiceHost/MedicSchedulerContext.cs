using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.DataModel;

namespace MS.WcfServiceHost
{
    public class MedicSchedulerContext : DbContext
    {
       
        public MedicSchedulerContext()
            :base("MSConnection")
        { }

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }

        public virtual DbSet<Speciality> Specialties { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
    }
}
