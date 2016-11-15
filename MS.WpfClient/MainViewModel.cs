using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MS.DataModel;
using MS.ServiceContracts;

namespace MS.WpfClient
{
    public class MainViewModel 
    {      
        public MainViewModel()
        {
            //DesignerProperties.GetIsInDesignMode(this))
                //Patients = context.Patients.ToList();
                //Doctors = context.Doctors.ToList();
                Uri tcpUri = new Uri("http://localhost:8000/MedicSchedulerService");
                EndpointAddress address = new EndpointAddress(tcpUri);
                BasicHttpBinding binding = new BasicHttpBinding("basicHttp");
                ChannelFactory<IMedicSchedulerService> factory = new ChannelFactory<IMedicSchedulerService>(binding, address);
                IMedicSchedulerService service = factory.CreateChannel();
                Appointments = service.GetAppointmentsByPatient(null);
        }
       
        public List<Appointment> Appointments { get; set; }
        public List<Patient> Patients { get; set; }

        public List<Doctor> Doctors { get; set; }
    
    }
}
