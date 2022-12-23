using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
  public  class Liberary:BaseEntity
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public Book[] books;
        public Liberary(string name,int size)
        {
            Name = name;
            books = new Book[size];

        }
        public Book this[int index]
        {
            get
            {
                if (index < books.Length && books[index]!=null)
                {
                    return books[index];
                }
                throw new Exception();
            }
            set
            {
                if (index < books.Length )
                {
                    books[index] = value;
                }

            }
        }
       
    }
}
