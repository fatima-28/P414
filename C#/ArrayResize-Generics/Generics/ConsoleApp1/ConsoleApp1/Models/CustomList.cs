using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class CustomList<T>
    {
        public int Id { get; set; }
        static int _id=0;
        public T[] list;
        public CustomList()
        {
            list = new T[0];
            _id++;
            Id = _id;
        }
        public void Add(T item)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = item;

        }
        public T[] GetAll()
        {
            return list;
        }


       

        //Daha sonra asagidaki classlariniz ve propertyleriniz olmalidir:
        //            Room - Id,RoomNo,Capacity
        //Student - Id,Name,Surname,Age,AvarageMark
        //Faculty - Id,Name
        //University - Id,Name,Capacity,PassingScore
        //Emplooyee - Id,Name,Surname,Age,Salary
        //Product - Id,Name,Count,Price,IsDeleted

        //Id - lerin hamisi static artan olmalidir,
        //  Butun propertyler uygun classlarin constructorlarindan gonderilmelidir.

        //CustomList classinizda Add ve GetAll metodlariniz olmalidir.Program.cs de her bir type ucun
        //list yaradin(CustomList classinizdan instance alaraq list objectleri),
        //icerisne uygun objectleri yigin ve GetAll vasitesile ekrana cixarin:

        //            Meselen - Productlar uchun productList olmalidir ve icine productlar yigilmalidir.
        //Studentsler ucun studentsList olmali ve icine studentsler yigilmalidir. 
    }
}
