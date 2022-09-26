using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseApp.Models
{
    public class Doctor : Person
    {
        public int ID { get; set; }
        public int Cabinet_number { get; set; }
    }
}
