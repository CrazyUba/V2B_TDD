using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Person
    {
        public int Age { get; set; }
        public string City { get; set; }

        public Person()
        {
            Age = 40;
            City = "Krefeld";
        }
    }
}
