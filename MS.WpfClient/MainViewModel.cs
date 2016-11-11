using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MS.DataModel;

namespace MS.WpfClient
{
    public class MainViewModel 
    {      
        public MainViewModel()
        {
            using (MedicSchedulerContext context = new MedicSchedulerContext())
            {
                Appointments = context.Appointments.ToList();
                Patients = context.Patients.ToList();
                Doctors = context.Doctors.ToList();
            }
        }
       
        public List<Appointment> Appointments { get; set; }
        public List<Patient> Patients { get; set; }

        public List<Doctor> Doctors { get; set; }
    
    }
}
