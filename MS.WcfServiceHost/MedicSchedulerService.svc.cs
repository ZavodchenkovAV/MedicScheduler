using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;
using MS.DataModel;
using MS.ServiceContracts;

namespace MS.WcfServiceHost
{
    public class MedicSchedulerService : IMedicSchedulerService
    {
        public List<Appointment> GetAppointmentsByPatient(long patientId)
        {
            using (MedicSchedulerContext context = new MedicSchedulerContext())
            {
                context.Configuration.ProxyCreationEnabled = false;
                var query = context.Appointments
                    .Include(x => x.Patient)
                    .Include(x => x.Doctor)
                    .Include(x => x.Doctor.Speciality);
                return query.ToList();

                //return patientId.HasValue ? query.Where(a => a.PatientId == patientId.Value).ToList()
                //    : query.ToList();
            }
        }
        public Message ComposeMessage(string header, string body)
        {
                using (MedicSchedulerContext context = new MedicSchedulerContext())
                {
                    context.Configuration.ProxyCreationEnabled = false;
                    var query = context.Appointments
                        .Include(x => x.Patient)
                        .Include(x => x.Doctor)
                        .Include(x => x.Doctor.Speciality).ToList();
                }
            Message message = new Message() { Header = $"2{header}", Body = body };

            return message;
        }
    }
}
