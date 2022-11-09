using Student_Group_University.Models;
using System;

namespace Student_Group_University
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Student classiniz var. Icherisinde Id(hansi ki el ile daxil etmeyeceksiz,avtomatik artacaq),
            //            Name,Surname,Age,IsGraduated,AvarageMark kimi propertyler var.
            //Group classiniz var.Onun da avtomatik artan Id propertysi ve GroupNo propertysi olmalidir.
            //Group classinizda Add metodunuz olmalidir.Ve o metod vasitesile grupa studentleri add ede bilmelisiz.
            //GetAllStu metodunuz vasitesile butun studentleri gormelisiz.
            //Faculty classiniz olmalidir.Onun da Id si ve Name-si olmalidir.fakultelere gruplar elave etmek ucun
            //de AddGroup metodu yazmalisiz.GetAllGroup vasitesi ile butun qrup infolarini elde etmelisiz.
            //University classiniz olmalidi.Onun da static artan Id propertysi ve Name propertysi olmalidir.
            //universtietlere fakulteler add etmek ucun AddFaculty metodu yazmalisiz. Eyni zamanda GetAllFaculty
            //metodunuz vastesile butun fakulte melumatlarini elde etmelisiz. 
            Student stu1 = new Student("Gultac", "Ceferova", false, 66);
            Student stu2 = new Student("Anar", "Huseynov", false, 65);

            Group group1 = new Group(414);
            Group group2 = new Group(130);
            group1.Add(stu1);
            group1.Add(stu2);

            //foreach (var item in group1.students)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name}");
            //}
            Faculty faculty1 = new Faculty("Tetbiq");
            Faculty faculty2 = new Faculty("Muhendis");
            faculty1.Add(group1);
            faculty1.Add(group2);

            faculty2.Add(group1);
            faculty2.Add(group2);
            // faculty1.GetGroups();

            University uni1 = new University("BDU");

            uni1.Add(faculty1);
            uni1.Add(faculty2);

            foreach (var item in uni1.GetFaculties())
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }

            #endregion


           

        }
    }
}
