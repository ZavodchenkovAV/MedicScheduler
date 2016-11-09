using System;
using System.Collections.Generic;
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
        public long AppointmentId { get; set; }

        public long PatientId { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public long DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        public DateTime ReceptionTime { get; set; }

        [StringLength(2000)]
        public string Text { get; set; }
    }
}
