using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Car:Vechile
    {
        public string Color { get; set; }
        private int _maxSpeed;
        public int MaxSpeed { 
            get { return _maxSpeed; } 
            set { _maxSpeed = value; } 
        }
        public string Model { get; set; }

        public Car(string carName,string carColor,int CarMaxSpeed,string CarModel):base(carName)
        {
            Color = carColor;
            MaxSpeed = CarMaxSpeed;
            Model = CarModel;
        }
        public override void  ReturnAllInfo()
        {
            Console.WriteLine($"{Id} {Name} {Model} {MaxSpeed} {Color}");

        }
       

        

        
    }
}
