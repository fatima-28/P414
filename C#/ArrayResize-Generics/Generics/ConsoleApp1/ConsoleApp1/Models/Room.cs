using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Room
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
        public Room(int capacity,string name)
        {
            Capacity = capacity;
            Name = name;
        }
    }
}
