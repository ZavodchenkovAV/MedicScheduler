using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MS.DataModel
{
    [DataContract(IsReference = true)]
    public class Patient:Person
    {
        [StringLength(20)]
        [DataMember]
        public string PolicyNumber { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public Sex Sex { get; set; }
        [DataMember]
        public virtual ICollection<Appointment> Appointments { get; set; }

        public override string ToString()
        {
            return $"Surname:{Surname},Name:{Name},BirthDate: {BirthDate},Sex:{Sex}";
        }
    }
}
