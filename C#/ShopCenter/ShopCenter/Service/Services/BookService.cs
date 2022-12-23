using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class BookService : IBookService
    {
        public void GetAllBooks()
        {
            var libs = GetAll();
            foreach (var lib in libs)
            {
                Console.WriteLine("\n *" + lib.Name);
                if (lib!=null)
                {
                    foreach (var book in lib.books)
                    {
                        if (book!=null)
                        {
                            Console.WriteLine($"{book.Name} {book.Genre} {book.Author} {book.Price}");
                        }
                    }
                }
            }
        }
        private Liberary[] GetAll()
        {
            ShopCenter shop = new ShopCenter(2);
            Liberary lib1 = new Liberary("Axundov", 10);
            Liberary lib2 = new Liberary("Libraff", 20);
            Book book1 = new Book("1984", "Dram", "George Orwell", 25);
            Book book2 = new Book("Harry Potter", "Adventure", "J.K.Rowling", 30);
            Book book3 = new Book("Design101", "Education", "A.Professor", 29);
            shop[0] = lib1;
            shop[1] = lib2;
            lib1[0] = book1;
            lib1[1] = book2;
            lib2[2] = book3;
            return shop.liberaries;
          
        }
    }
}
