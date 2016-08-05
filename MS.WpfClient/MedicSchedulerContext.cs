using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.DataModel;

namespace MS.WpfClient
{
    public class MedicSchedulerContext : DbContext
    {
        public MedicSchedulerContext()
            :base("MSConnection")
        { }

        public DbSet<Patient> Patients { get; set; }
    }
}
