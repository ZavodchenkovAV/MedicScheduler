using MS.DataModel;
using MS.ServiceContracts;
using System;
using System.Data.Entity;
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
                context.Configuration.ProxyCreationEnabled = false;
                var query = context.Appointments
                    .Include(x => x.Patient)
                    .Include(x => x.Doctor);

                return patientId.HasValue? query.Where(a=>a.PatientId == patientId.Value).ToList()
                    : query.ToList();
            }
        }
    }
}
