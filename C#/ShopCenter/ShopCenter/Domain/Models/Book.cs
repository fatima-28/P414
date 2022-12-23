using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
  public  class Book:BaseEntity
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public Book(string name, string genre,string author,double price)
        {
            Name = name;
            Genre = genre;
            Author = author;
            Price = price;
        }
        public static bool operator <(Book b1,Book b2)
        {
            return b1.Price < b2.Price;

        }
        public static bool operator >(Book b1, Book b2)
        {
            return b1.Price > b2.Price;

        }
    }
}
