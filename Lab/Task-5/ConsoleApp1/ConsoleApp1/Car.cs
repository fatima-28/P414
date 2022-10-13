using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        //  Task 1 : Bir Car classiniz var . Eger masinin qiymeti
        //  15.000 den ucuzdursa ekrana ucuz yazsin.
        // eger 15.000 - 30.000 araligindadirsa orta qiymetli
        // 30.000 + baha yazsin
        public void CheckCarPrice(double price)
        {
            if (price<15000)
            {
                Console.WriteLine("ucuz");
            }
            else if (price>=15000&&price<=30000)
            {
                Console.WriteLine("orta qiymetli");
            }
            else
            {
                Console.WriteLine("baha");
            }
        }
    }
}
