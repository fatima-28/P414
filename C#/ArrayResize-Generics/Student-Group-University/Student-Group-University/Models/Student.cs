using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Group_University.Models
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsGraduated { get; set; }
        public int AvarageMark { get; set; }
        static int _id=1;

        public Student(string name,string surname,bool isGraduated,int avarageMark)
        {
          
            Id = _id++;
            Name = name;
            Surname = surname;
            IsGraduated = isGraduated;
            AvarageMark = avarageMark;
        }
       
    }
}
