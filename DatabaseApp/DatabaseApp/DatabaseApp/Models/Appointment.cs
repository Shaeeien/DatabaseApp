﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseApp.Models
{
    public class Appointment
    {
        public Patient AppointingPerson { get; set; }
        public Doctor Doctor { get; set; }
        public int ID { get; set; }
        public DateTime Time { get; set; }

        
    }
}
