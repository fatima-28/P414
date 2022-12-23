using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Bus:Vechile
    {
        
        public int PassengerCount { get; set; }
        public Bus(string busName, int PsgCnt):base(busName)
        {
            PassengerCount = PsgCnt;
        }
        public override void ReturnAllInfo()
        {
            Console.WriteLine($"{Id} {Name} {PassengerCount}");
        }
    }
}
