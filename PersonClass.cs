using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Person
    {
        internal int age { get; set; }
        internal string name { get; set; }
        internal string role { get; set; }

 
        public Person(int Age, string Name, string Role)
        {
            age = Age;
            name = Name;
            role = Role;
        
        }


    }
}
