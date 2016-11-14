using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using MS.DataModel;
using MS.ServiceContracts;

namespace MS.WpfClient
{
    public class MainViewModel 
    {      
        public MainViewModel()
        {
            
                //Patients = context.Patients.ToList();
                //Doctors = context.Doctors.ToList();
                Uri tcpUri = new Uri("http://localhost:8000/MedicSchedulerService");
                // Создаём сетевой адрес, с которым клиент будет взаимодействовать
                EndpointAddress address = new EndpointAddress(tcpUri);
                BasicHttpBinding binding = new BasicHttpBinding("basicHttp");
                // Данный класс используется клиентами для отправки сообщений
                ChannelFactory<IMedicSchedulerService> factory = new ChannelFactory<IMedicSchedulerService>(binding, address);
                // Открываем канал для общения клиента с со службой
                IMedicSchedulerService service = factory.CreateChannel();
                Appointments = service.GetAppointmentsByPatient(null);
        }
       
        public List<Appointment> Appointments { get; set; }
        public List<Patient> Patients { get; set; }

        public List<Doctor> Doctors { get; set; }
    
    }
}
