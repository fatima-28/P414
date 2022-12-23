using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public Product(double price , string name,bool isDeleted)
        {
            Name = name;
            Price = price;
            IsDeleted = isDeleted;
        }
    }
}
