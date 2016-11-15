using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MS.DataModel
{
    [DataContract]
    public enum Sex:short
    {
        [EnumMember]
        [Description("Male")]
        Male,
        [EnumMember]
        [Description("Female")]
        Female
    }
}
