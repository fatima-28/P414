using Casting.Models;
using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1.Products classiniz var, Id Price Title propertyleri olsun
            //            Technologys Productdan miras alir, onun da Model propu var.
            //Laptop classiniz olsun, Ram propertysi olsun ve Technologysden miras alsin.
            //Vegetables classiniz var,Productsdan miras alir,Kq propertysi var.
            //Patato classiniz olsun, Sort deye bir propu olsun, vegetablesden miras alsin.
            //Laptop classinda bir Show metodunuz olsun ve ekrana Laptop yazdirsin
            //Upcasting edin yeni,laptopa product kimi yanashin.
            //Products tipinden bir array yaradin ve patatodan ve laptopdan yaratdiginiz objleri
            //icine yigin.
            //Unboxing ederek sadece laptop olanlari elde edin.(is ve ya as keywordunden istifade edin)

            //Laptop laptop1 = new Laptop();
            //Product laptop2 = laptop1;  //boxing

            Product laptop3 = new Laptop();
            Product laptop4 = new Laptop();
            Product patato1 = new Patato();


            Product[] products = {laptop3,laptop4,patato1 };
            foreach (var item in products)
            {
                ////with as
                Laptop l = item as Laptop;
                if (l != null)
                {
                    l.Show();
                }

                //// with is
                //if (item is Laptop l)
                //{
                //    l.Show();

                //}

            }

            #endregion

            #region Task2

            //            2.SchoolMark classinz var, icinde schoolPoint propu var.UniMark classiniz var
            //           icinde midterm propunuz var.Universtitet balini(100 uzerinden olan bali) , 
            //mekteb balina(5 uzerinden olan bala) ceviren implicit operator yazin


            UniMark mark = new UniMark(100);
            SchoolMark point = mark;
            Console.WriteLine(point.SchoolPoint);
            #endregion


        }
    }
}
