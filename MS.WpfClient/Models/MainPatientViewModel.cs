using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using MS.DataModel;
using MS.ServiceContracts;

namespace MS.WpfClient.Models
{
    public class MainPatientViewModel 
    {      
        public MainPatientViewModel()
        {
            if(!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                InitRunTime();
        }
       
        public List<AppointmentViewModel> Appointments { get; set; }

        public void InitRunTime()
        {
            Uri tcpUri = new Uri("http://localhost:8000/MedicSchedulerService");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding("basicHttp");
            ChannelFactory<IMedicSchedulerService> factory = new ChannelFactory<IMedicSchedulerService>(binding, address);
            IMedicSchedulerService service = factory.CreateChannel();
            Appointments = service.GetAppointmentsByPatient(null).Select(a=>new AppointmentViewModel(a)).ToList();
        }
    }
   
}
