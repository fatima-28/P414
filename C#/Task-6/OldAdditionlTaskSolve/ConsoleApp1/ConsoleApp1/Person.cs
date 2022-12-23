using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
       
        public virtual void GetInformation()
        {

            Console.WriteLine($"This persons informations are:{Name} {Surname} {Age}");
            
        }
    }
}
