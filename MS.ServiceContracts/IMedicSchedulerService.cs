using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.DataModel;

namespace MS.ServiceContracts
{
    [ServiceContract]
    public interface IMedicSchedulerService
    {
        [OperationContract]
        List<Appointment> GetAppointmentsByPatient(long? patientId);
    }
}
