using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MS.DataModel
{
    [DataContract(IsReference = true)]
    public class Appointment
    {
        [Key]
        [Browsable(false)]
        [DataMember]
        [Display(Name = "AppointmentId", ResourceType = typeof(Properties.Resources))]
        public long AppointmentId { get; set; }

        [Display(Name = "Patient", ResourceType = typeof(Properties.Resources))]
        [DataMember]
        public long PatientId { get; set; }

        [ForeignKey("PatientId")]
        //[Browsable(false)]
        [DataMember]
        public Patient Patient { get; set; }

        [Display(Name = "Doctor", ResourceType = typeof(Properties.Resources))]
        [DataMember]
        public long DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        [Browsable(false)]
        [DataMember]
        public Doctor Doctor { get; set; }

        [DataMember]
        public DateTime ReceptionDateTime { get; set; }

        [StringLength(2000)]
        [Display(Name = "ReceptionText", ResourceType = typeof(Properties.Resources))]
        [DataMember]
        public string Text { get; set; }
        public override string ToString()
        {
            return $"Patient:{Patient.Surname},{Patient.Name},Doctor:{Doctor.Surname},{Doctor.Speciality.Name},ReceptionTime: {ReceptionDateTime}";
        }
    }
    [DataContract]
    public class Message
    {
        [DataMember]
        public string Header { get; set; }

        [DataMember]
        public string Body { get; set; }
    }
}
