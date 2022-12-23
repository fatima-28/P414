using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student:Person
    {
        public int AvarageMark { get; set; }
        public bool IsGraduated { get; set; }

        public override void GetInformation()
        {
            Console.WriteLine($"This student informations are:{Name} {Surname} {Age} {AvarageMark} {IsGraduated}");
        }
    }
}
