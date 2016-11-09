using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.DataModel
{
    public class Doctor:Person
    {
        public long? SpecialtyId { get; set; }
        public Speciality Specialty { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
