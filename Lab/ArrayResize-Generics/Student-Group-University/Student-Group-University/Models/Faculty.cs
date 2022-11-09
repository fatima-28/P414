using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Group_University.Models
{
    class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        static int _id = 1;
        public Group[] groups;

        public Faculty(string name)
        {
            groups = new Group[0];
            Id = _id++;
            Name = name;
        }
        public void Add(Group group)
        {
            Array.Resize( ref groups,groups.Length+1);
            groups[groups.Length - 1] = group;

        }
        public void GetGroups()
        {
            foreach (var item in groups)
            {
                Console.WriteLine($"{item.Id} {item.GroupNo}");
            }

        }
 
    }
}
