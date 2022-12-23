using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Group_University.Models
{

    //University classiniz olmalidi.Onun da static artan Id propertysi ve Name propertysi olmalidir.
    //universtietlere fakulteler add etmek ucun AddFaculty metodu yazmalisiz. Eyni zamanda GetAllFaculty
    //metodunuz vastesile butun fakulte melumatlarini elde etmelisiz.
     class University
    {
        public int Id { get; set; }
        static int _id=0;
        public Faculty[] faculties;

        public string Name { get; set; }

        public University(string name)
        {
            Name = name;
            _id++;
            Id = _id;

            faculties = new Faculty[0];
        }

        public void Add(Faculty faculty)
        {
            Array.Resize(ref faculties, faculties.Length + 1);
            faculties[faculties.Length - 1] = faculty;
        }

        public Faculty[] GetFaculties()
        {
            return faculties;
        }

    }
}
