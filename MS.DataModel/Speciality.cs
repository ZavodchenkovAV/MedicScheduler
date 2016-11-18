using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MS.DataModel
{
    [DataContract(IsReference = true)]
    public class Speciality
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public long Id { get; set; }

        [Display(Name = "Speciality", ResourceType = typeof(Properties.Resources))]
        [DataMember]

        public string Name { get; set; }
    }
}
