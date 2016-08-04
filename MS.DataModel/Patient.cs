using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.DataModel
{
    public class Patient
    {
        public long PolicyId { get; set; }
        public long Surname { get; set; }
        public long Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
