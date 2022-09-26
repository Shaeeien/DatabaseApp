using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseApp.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }
    }
}
