using ConsoleApp1.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task



            //Ekran acilanda size 3 option verir
            //1.Show All products
            //Konsoldan 1 daxil edende Butun productlarinizin melumatlarini gostermelidir

            //2.Add Products
            //Konsoldan 2 daxil edende
            //Yeni bir product yaratmaq ucun sizden ProductName, Product price istemelidir.
            //Ve yeni yaranan productu listinize add etmelidir

            //3.Remove Product
            //Konsoldan 3 daxil olunanda sizden silmek istediyiniz productun adini istemelidir.
            //ve hemin addaki productu listden silmelidir,
            //Listin Remove metodu ile yox ,IsDeleted propertysi vasitesile edin.

            //Eger konsoldan daxil olan eded 3den ferqlidise onda ekrana "bele bir secim yoxdu" cixsin


            //Product classiniz var. Name,price ve isDeletd proplari var.
            // custom bir Delegate yazirsiz.(asanliq ucun evvelce 2
            // delegate yazirsiz daha sonra genericlesdireceksiniz)
            // GetProduct metodunuz olmalidir ve
            // parametr olaraq 2 metod ve product tipinden bir list qebul elemelidir.
            //Metodlardan biri CheckPrice(), productun qiymetinin 500 den boyuk
            //olub olmadigini yoxlamalidir, Diger metodunuz GetDiscount() , price qebul edir ve
            //hemin pricenin 30 faiz endirimli qiymetini return edir.
            //GetProduct metodunuz ekrana isDeletedi false olan productlarin informasiyalarini
            //cixarmalidir. eger product endirime dusubse(qiymeti 500 den coxdusa) onda hemde
            //yanina endirimli yazilmalidir


            #endregion

            Console.WriteLine("1.Show All Product");
            Console.WriteLine("2.Add Product");
            Console.WriteLine("3.Remove Product");
            Product p1 = new Product("Iphone", 5000, false);
            Product p3= new Product("Nokia", 100, false);
            Product p4 = new Product("Samsung", 800, false);
            Product p5 = new Product("Redmi", 1500, true);
            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);

            int num = int.Parse(Console.ReadLine());
            if (num==1)
            {
                GetProduct(CheckPrice, GetDiscount, products);
            }
            else if (num==2)
            {
                Console.Write("Enter product name: ");
                string name = Console.ReadLine();
                Console.Write("Enter product price: ");
                double price = double.Parse(Console.ReadLine());
                Product p = new Product(name,price,false);
                products.Add(p);
                GetProduct(CheckPrice, GetDiscount, products);
                //P.S: Burada listi foreache salib da yaza bilerik amma onda qiymetlerin endirimli
                //olub olmadigini yoxlamayacaq 

            }
            else if (num==3)
            {
                Console.WriteLine( "Elimizde olanlar:");
                GetProduct(CheckPrice, GetDiscount, products);
                Console.WriteLine("Silmek istediyinizin adini daxil edin:");
                string name = Console.ReadLine();
                foreach (var item in products)
                {
                    if (item.Name.ToLower()==name.ToLower())
                    {
                        item.IsDeleted = true;
                    }
                }

                GetProduct(CheckPrice, GetDiscount, products);

            }
            else
            {
                Console.WriteLine("Bele bir secim yoxdur");
            }

           


        }
        public static double GetDiscount(double price)
        {
            return price * 0.7;
        }
        public static bool CheckPrice(double price)
        {
            return price > 500;

        }
        public static void GetProduct(Check<bool> checkPrice,Check<double> discountPrice,List<Product> list)
        {
            foreach (var item in list)
            {
                if (!item.IsDeleted)
                {
                    if (checkPrice(item.Price))
                    {
                        Console.WriteLine($"{item.Name} {discountPrice(item.Price)} endirimli");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name} {item.Price} ");
                    }
                }
            }

        }
    }
}
