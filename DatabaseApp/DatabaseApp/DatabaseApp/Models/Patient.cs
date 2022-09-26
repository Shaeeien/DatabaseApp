using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseApp.Models
{
    public class Patient : Person
    {
        public int ID { get; set; }
        public Doctor Doctor_data { get; set; }
    }
}
