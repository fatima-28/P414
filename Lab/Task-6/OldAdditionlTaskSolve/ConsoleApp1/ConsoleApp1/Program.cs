using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person classiniz var. Name Surname Age propertyleri var.
            //            Employee(salary ve position propertyleri olan) ve students(AvarageMark, IsGraduated proplari olan)
            // classlariniz da var, her iksi Persondan miras alir.
            //Personda GetInformations metodunuz var. Bu metod Student ve Employeede override olmalidir ve
            //hansi classa aiddirse o classin butun infolarini cixarmalidir.
            //meselen: Hemin metodu Employeeden instance alib cagiranda ekrana:"This employee informations is
            // Resul, Hesenov,15,10000, director cixmalidir. Diger classlar ucun de eyni sekilde uygun olan
            // melumatlari cixarmalidir

            Person p = new Person();
            p.Name = "Resul";
            p.Surname = "Hesenov";
            p.Age = 15;
            p.GetInformation();
            Employee emp = new Employee();
            emp.Name = "Gultac";
            emp.Surname = "Ceferova";
            emp.Age = 18;
            emp.Position = "director";
            emp.Salary = 1500;
            emp.GetInformation();
            Student stu = new Student();
            stu.Name = "Nicat";
            stu.Surname = "Novruzzade";
            stu.Age = 21;
            stu.AvarageMark = 85;
            stu.IsGraduated = false;
            stu.GetInformation();
            



        }
}
}
