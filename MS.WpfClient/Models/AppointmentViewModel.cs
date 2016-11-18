using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.DataModel;

namespace MS.WpfClient.Models
{
    public class AppointmentViewModel
    {
        private readonly Appointment _appointment;
        public AppointmentViewModel(Appointment appointment)
        {
            _appointment = appointment;
        }

        [Display(Name = "AppointmentId", ResourceType = typeof(DataModel.Properties.Resources))]
        public long AppointmentId => _appointment.AppointmentId;

        [Display(Name = "ReceptionDate", ResourceType = typeof(DataModel.Properties.Resources))]
        public DateTime ReceptionDate => _appointment.ReceptionDateTime;
        [Display(Name = "ReceptionTime", ResourceType = typeof(DataModel.Properties.Resources))]
        public DateTime ReceptionTime => _appointment.ReceptionDateTime;

        [Display(Name = "Speciality", ResourceType = typeof(DataModel.Properties.Resources))]
        public string Speciality => _appointment.Doctor.Speciality.Name;
        [Display(Name = "Doctor", ResourceType = typeof(DataModel.Properties.Resources))]
        public string DoctorFullName => $"{_appointment.Doctor.Surname} {_appointment.Doctor.Name}";
    }
}
