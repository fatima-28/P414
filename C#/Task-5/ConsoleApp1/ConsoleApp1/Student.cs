using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Task 2,3,4,5- Bir Student classiniz olsun. 3 fieldi olsun- ad soyad yash.
    class Student
    {

        public string name;
        public string surname;
        public int age;
        #region Task2
        //Task 2-
        // AllInfo adinda bir metodunuz olsun ve studentin butun melumatlarini qaytarsin
        public void AllInfo(string StuName, string StuSurname, int StuAge)
        {

            Console.WriteLine($"Telebe adi, soyadi ve yashi: {StuName},{StuSurname},{StuAge}");
        }
        #endregion


        #region Task3
        //Task 3-Bir Student classiniz olsun. 3 fieldi olsun ad soyad yash.
        //butun melumatlari constructor vasitesi ile bize qaytarsin
        //public Student(string name,string Surname,int Age)
        //{
        //    this.name = name;
        //    surname = Surname;
        //    age = Age;
        //    Console.WriteLine($"Ad: {name}, Soyad : {surname}, Yash: {age}");

        //}

        #endregion

        #region Task4
        //  Task4-Student classiniz var 3 fieldiniz var. 3 constructorunuz var . 
        //1.parametrsiz constructor ise dusende ekrana "hello student" yazilsin.
        //2. Diger constructor ad ve soyad qebul etsin.
        //3. Son constructor ad soyad ve yashi qebul edir. Ekrana constructorlardan istifade
        //ederek telebenin ad soyad ve yasini cixarmalisiz

        public Student()
        {
            Console.WriteLine("Hello Student!");
        }
        public Student(string Name,string Surname)
        {
            name = Name;
            surname = Surname;
        }
        public Student(string Name, string Surname,int Age):this(Name,Surname)
        {
            age = Age;
           // Console.WriteLine($"Ad: {name}, Soyad : {surname}, Yash: {age}");
        }
        #endregion

   


    }
}
