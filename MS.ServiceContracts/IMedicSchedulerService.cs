using System;
using System.ServiceModel;
using System.ServiceModel.Web;
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
        [WebGet(UriTemplate = "/GetAppointmentsByPatient/?patientId={patientId}", ResponseFormat = WebMessageFormat.Xml)]
        List<Appointment> GetAppointmentsByPatient(long patientId);

        [OperationContract]
        [WebGet(UriTemplate = "/GetMessage/?header={header}&?body={body}", ResponseFormat = WebMessageFormat.Xml)]
        Message ComposeMessage(string header, string body);
    }
}
