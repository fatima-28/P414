using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //konsolda 10-99 arasi eded daxil olunur. daxil olunan ededi 
            //            string formatinda ekrana cixarin. 
            //Array isletmeyin
            //meselen:
            //            consoleden 75 daxil edirsiz. ekrana"seventy five "
            // cixmalidir

            int num = int.Parse(Console.ReadLine());//95
            int firstNum = num / 10;
            int LastNum = num % 10;
            string NumConverter = string.Empty;
            if (num <= 19)
            {
                switch (num)
                {
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fiveteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                }

                }
            else
            {
                switch (num/10)
                {
                    case 2:
                        NumConverter = "twenty ";
                        break;
                    case 3:
                        NumConverter = "thirty ";
                        break;
                    case 4:
                        NumConverter = "fourty ";
                        break;
                    case 5:
                        NumConverter = "fivety ";
                        break;
                    case 6:
                        NumConverter = "sixty ";
                        break;
                    case 7:
                        NumConverter = "seventy ";
                        break;
                    case 8:
                        NumConverter = "eighty ";
                        break;
                    case 9:
                        NumConverter = "ninety ";
                        break;

                }

                switch (LastNum)
                {
                    case 0:
                        Console.WriteLine(NumConverter);
                        break;
                    case 1:
                        Console.WriteLine(NumConverter+"one");
                        break;
                    case 2:
                        Console.WriteLine(NumConverter + "two");
                        break;
                    case 3:
                        Console.WriteLine(NumConverter + "three");
                        break;
                    case 4:
                        Console.WriteLine(NumConverter + "four");
                        break;
                    case 5:
                        Console.WriteLine(NumConverter + "five");
                        break;
                    case 6:
                        Console.WriteLine(NumConverter + "six");
                        break;
                    case 7:
                        Console.WriteLine(NumConverter + "seven");
                        break;
                    case 8:
                        Console.WriteLine(NumConverter + "eight");
                        break;
                    case 9:
                        Console.WriteLine(NumConverter + "nine");
                        break;
                }
            }

        
    
        }
    }
}
