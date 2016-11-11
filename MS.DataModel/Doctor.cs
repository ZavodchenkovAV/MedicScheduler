using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.DataModel
{
    public class Doctor:Person
    {
        public long? SpecialityId { get; set; }

        [ForeignKey("SpecialityId")]
        public Speciality Speciality { get; set; }

        public byte[] Photo { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public override string ToString()
        {
            return $"Surname:{Surname},Name:{Name},Speciality: {Speciality?.Name}";
        }
    }
}
