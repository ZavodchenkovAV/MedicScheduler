using MS.DataModel;
using MS.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.ServiceHost
{
    public class MedicSchedulerService: IMedicSchedulerService
    {
        public List<Appointment> GetAppointmentsByPatient(long? patientId)
        {
            using (MedicSchedulerContext context = new MedicSchedulerContext())
            {
                return patientId.HasValue? context.Appointments.Where(a=>a.PatientId ==patientId.Value).ToList()
                    : context.Appointments.ToList();
            }
        }
    }
}
