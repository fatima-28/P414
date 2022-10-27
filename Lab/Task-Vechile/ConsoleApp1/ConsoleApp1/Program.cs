using ConsoleApp1.Extensions;
using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        //Vehicle classiniz var. Id ve Name propertylri var. 
        //            Propertyleriniz constructorda set olunur.
        //Car classi vehicle den miras alir. Color,MaxSpeed,Model propertyleri var.
        //Burada propertyleriniz constructorda set olunur ve base keywordunden istifade edirsiniz.
        //_maxSpeed fieldiniz var ve privatedir.maxspeedi encapsulate edin.

        //1.ReturnAllInfo metodunuz butun melumatlari qaytarmalidir. Bu metod
        //Vechile classinda  olmalidir ve
        // ondan miras alan butun classlarda override olunmalidir.

        //2.Id propertysini siz elinizle set etmemelisiniz, avtomatik ozu artmali ve unique olmalidir.

        //3.maxSpeed ucun extension yazmalisiniz, eger 250 den boyuk deyer alarsa, "Bu adli masinin suretinde sehvlik var"
//        ekrana cixsin.
       
//4.Car tipinden bir array yaradin ve icine carlarinizi yigib ekrana melumatlarini gosterin.

//5.Bus classi yaradin ve Vehicleden miras alsin, elave bir PassengerCount propertysi olsun.
//       ReturnAllInfo-nu Bus ucun de override edin
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW","Yellow",100,"I8");
            Car car2 = new Car("Nissan", "Yellow", 1200, "I9");
            car1.ReturnAllInfo();
            car2.ReturnAllInfo();
            car1.MaxSpeed.ChehckSpeed(car1.Name);
            Bus bus1 = new Bus("Daewo", 20);
            Bus bus2 = new Bus("BakuBus", 50);
            bus1.ReturnAllInfo();
            bus2.ReturnAllInfo();

            Car[] cars = {car1,car2 };
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Name} {item.Color}");

            }

        }
}
}
