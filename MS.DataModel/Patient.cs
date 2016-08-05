using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.DataModel
{
    public class Patient
    {
        [Key]
        public long PolicyId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
