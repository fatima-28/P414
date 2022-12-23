using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Extensions
{
    static class Extension
    {
        public static void ChehckSpeed(this int speed,string name)
        {
            if (speed>250)
            {
                Console.WriteLine($"{name} adli mashinin sureti duzgun deyil!");
            }
        }

        
    }
}
