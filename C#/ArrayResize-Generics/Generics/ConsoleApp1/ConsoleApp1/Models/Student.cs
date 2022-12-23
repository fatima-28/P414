using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public Student(int age,string name)
        {
            Name = name;
            Age = age;
        }
    }
}
