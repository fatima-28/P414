using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee:Person
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override void GetInformation()
        {
            Console.WriteLine($"This employee informations are:{Name} {Surname} {Age} {Position} {Salary}");
        }
    }
}
