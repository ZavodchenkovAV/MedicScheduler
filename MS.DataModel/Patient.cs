﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.DataModel
{
    public class Patient:Person
    {
        public string PolicyNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public Sex Sex { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
