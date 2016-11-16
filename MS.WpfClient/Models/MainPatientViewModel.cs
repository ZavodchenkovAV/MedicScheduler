using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MS.DataModel;
using MS.ServiceContracts;

namespace MS.WpfClient.Models
{
    public class MainPatientViewModel 
    {      
        public MainPatientViewModel()
        {
            //DesignerProperties.GetIsInDesignMode(this))
                //Patients = context.Patients.ToList();
                //Doctors = context.Doctors.ToList();
                //InitDesignTime();
        }
       
        public List<Appointment> Appointments { get; set; }

        public void InitRunTime()
        {
            Uri tcpUri = new Uri("http://localhost:8000/MedicSchedulerService");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding("basicHttp");
            ChannelFactory<IMedicSchedulerService> factory = new ChannelFactory<IMedicSchedulerService>(binding, address);
            IMedicSchedulerService service = factory.CreateChannel();
            Appointments = service.GetAppointmentsByPatient(null);
        }

        public void InitDesignTime()
        {
            Appointments = new List<Appointment>() {new Appointment() {ReceptionTime = DateTime.Now,Doctor = new Doctor() {Name = "sdfsdf"} } };
        }
    
    }
}
