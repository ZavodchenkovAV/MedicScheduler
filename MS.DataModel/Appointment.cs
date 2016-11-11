using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.DataModel
{
    public class Appointment
    {
        [Key]
        [Browsable(false)]
        public long AppointmentId { get; set; }

        [Display(Name = "Patient", ResourceType = typeof(Properties.Resources))]
        public long PatientId { get; set; }

        [ForeignKey("PatientId")]
        [Browsable(false)]
        public Patient Patient { get; set; }

        [Display(Name = "Doctor", ResourceType = typeof(Properties.Resources))]
        public long DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        [Browsable(false)]
        public Doctor Doctor { get; set; }

        [Display(Name = "ReceptionTime", ResourceType = typeof(Properties.Resources))]
        public DateTime ReceptionTime { get; set; }

        [StringLength(2000)]
        [Display(Name = "ReceptionText", ResourceType = typeof(Properties.Resources))]
        public string Text { get; set; }
        public override string ToString()
        {
            return $"Patient:{Patient.Surname},{Patient.Name},Doctor:{Doctor.Surname},{Doctor.Speciality.Name},ReceptionTime: {ReceptionTime}";
        }
    }
}
