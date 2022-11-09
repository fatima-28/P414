using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<Room> roomlist = new CustomList<Room>();
            Room room1 = new Room(10, "Saturn");
            Room room2 = new Room(20, "Venera");
            roomlist.Add(room1);
            roomlist.Add(room2);
            foreach (var item in roomlist.GetAll()) 
            {
                Console.Write(item.Capacity);
                Console.Write(item.Name);
            }

            #region MyRegion
            Student stu1 = new Student(21, "Nicat");
            Student stu2 = new Student(21, "Samir");
            Student stu3 = new Student(20, "Simare");
            Student stu4 = new Student(20, "Fatime");
            Product p1 = new Product(50000, "Iphone", false);
            Product p2 = new Product(3000, "Computer", false);

            CustomList<Student> stuList = new CustomList<Student>();
            CustomList<Product> productList = new CustomList<Product>();
            productList.Add(p1);
            productList.Add(p2);
            //foreach (var item in productList.list)
            //{
            //    Console.WriteLine($"{item.Name}{item.Price}");
            //}
            stuList.Add(stu1);
            stuList.Add(stu2);
            stuList.Add(stu3);
            stuList.Add(stu4);
            //foreach (var item in stuList.GetAll())
            //{
            //    Console.WriteLine($"{item.Name}{item.Age}");
            //}
            #endregion
            

        }
    }
}
