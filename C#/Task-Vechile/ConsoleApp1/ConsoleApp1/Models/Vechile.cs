using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Vechile
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        static int _id = 0;
   
        public Vechile(string vechileName)
        {

            _id++;
            Id = _id;
            Name = vechileName;
        }
        public virtual void ReturnAllInfo()
        {
            Console.WriteLine($"{Id} {Name}");

        }

        
    }
}
