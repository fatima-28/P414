using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public delegate T Check<out T>(double price);
   
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsDeleted { get; set; }
        public Product(string name,double price,bool isDeleted)
        {
            Name = name;
            Price = price;
            IsDeleted = isDeleted;
        }
    }
}
