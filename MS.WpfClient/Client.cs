using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using MS.DataModel;
using MS.ServiceContracts;

namespace MS.WpfClient
{
    public class Client : ClientBase<IMedicSchedulerService>,IMedicSchedulerService
    {
        public List<Appointment> GetAppointmentsByPatient(long patientId)
        {
            return Channel.GetAppointmentsByPatient(patientId);
        }

        public DataModel.Message ComposeMessage(string header, string body)
        {
            return Channel.ComposeMessage(header, body);
        }
    }
}