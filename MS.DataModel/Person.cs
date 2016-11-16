using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MS.DataModel
{
    [DataContract(IsReference = true)]
    public abstract class Person
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public long Id { get; set; }

        [StringLength(200)]
        [DataMember]
        public string Surname { get; set; }

        [StringLength(200)]
        [DataMember]
        public string Name { get; set; }
    }
}
