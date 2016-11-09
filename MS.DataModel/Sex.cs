using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.DataModel
{
    public enum Sex:short
    {
        [Description("Male")]
        Male,
        [Description("Female")]
        Female
    }
}
