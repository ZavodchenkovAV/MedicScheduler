using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MS.DataModel
{
    [DataContract(IsReference = true)]
    public class Doctor:Person
    {
        [DataMember]
        public long? SpecialityId { get; set; }

        [ForeignKey("SpecialityId")]
        [DataMember]
        public Speciality Speciality { get; set; }

        [DataMember]
        public byte[] Photo { get; set; }

        [DataMember]
        public virtual ICollection<Appointment> Appointments { get; set; }

        public override string ToString()
        {
            return $"Surname:{Surname},Name:{Name},Speciality: {Speciality?.Name}";
        }
    }
}
