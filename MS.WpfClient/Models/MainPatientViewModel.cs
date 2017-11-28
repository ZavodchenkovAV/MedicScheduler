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
            var service = CreateUri();
            //var service = CreateClientBase();

            Appointments = service.GetAppointmentsByPatient(1).Select(a=>new AppointmentViewModel(a)).ToList();
        }

        private IMedicSchedulerService CreateUri()
        {
            //Uri tcpUri = new Uri("http://localhost:8000/MedicSchedulerService");
            Uri tcpUri = new Uri("http://localhost/MS.WcfServiceHost/MedicSchedulerService");

            EndpointAddress address = new EndpointAddress(tcpUri);
            //BasicHttpBinding binding = new BasicHttpBinding("basicHttp");
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IMedicSchedulerService> factory = new ChannelFactory<IMedicSchedulerService>(binding, address);
            var channel =  factory.CreateChannel();
            return channel;
        }

        private IMedicSchedulerService CreateClientBase()
        {
            return new Client();
        }

        //private IMedicSchedulerService CreateChannel()
        //{
        //    ChannelFactory<IMedicSchedulerService> factory = new ChannelFactory<IMedicSchedulerService>("EndpointNameOfYourService");
        //    factory.Endpoint.Address = new EndpointAddress("http://example.com/service");

        //    IYourServiceContract client = factory.CreateChannel();
        //    var result = client.YourMethodtoInvoke(serviceArguments);
        //}
    }
   
}
