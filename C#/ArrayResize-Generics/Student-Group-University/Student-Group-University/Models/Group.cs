using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Group_University.Models
{
    class Group
    {
        public int Id { get; set; }
        public int GroupNo { get; set; }
        static int _id = 1;
        public Student[] students;

        public Group(int groupNo)
        {
            students = new Student[0];
            Id = _id++;
            GroupNo = groupNo;
        }
        public void Add(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;

        }
      public Student[] GetStudents()
        {
            return students;
        }
         
        
    }
}
