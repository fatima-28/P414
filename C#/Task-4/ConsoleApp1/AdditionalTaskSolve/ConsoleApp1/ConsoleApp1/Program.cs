using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TurnBinary(3));
            #region Task5
            //5.Arrayiniz var ve icinde aylar var, yaz ayi olanlari ekrana cixaran metod yazin

            string[] month = { "yanvar","sentyabr","dekabr","mart","aprel"};

            //  CheckSummerMonth(month);
            #endregion


            #region Task 6
            //            6.2 eyniadli metodunuz var, bunlardan biri 2 parametr digeri 3 parametr qebul
            //edir.Eger 2 parametr qebul ededin parametrlerinden en az 1i cutdurse cemini ekrana cixaran metod yazin.
            //Eger 3 parametrimizden en az biri tekdirse ekrana kvadratlarini cixarsin

            //  SumOrSquare(10, 4,5);

            #endregion


            #region Task 7
            //7.Size bir eded gelir.Bu ededi ikili say sistemindeki edede cevirende,
            // onda olan 1 lerin sayini tapib ekrana cixarsin(meselen ededimiz 3 dur - ikilik sistemde 11,
            //bize ekrana 2 cixarmalidir)


           
            #endregion

        }
        //public static void CheckSummerMonth(string[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        if (item=="mart"|| item == "aprel"|| item == "may")
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}
        //public static void SumOrSquare(int p1,int p2)
        //{
        //    if (p1%2==0||p2%2==0)
        //    {
        //        Console.WriteLine(p1+p2);
        //    }
        //}
        //public static void SumOrSquare(int p1, int p2,int p3)
        //{
        //    if (p1 % 2 != 0 || p2 % 2 != 0||p3%2!=0)
        //    {
        //        Console.WriteLine(Math.Pow(p1,2));
        //        Console.WriteLine(Math.Pow(p2,2));
        //        Console.WriteLine(Math.Pow(p3,2));
        //    }
        //}
       public static int TurnBinary(int n)
        {
            int rem = 0;
            int rev = 0;
            int count = 0;
            for (int i = 0; n > 0; i++)
            {
                rem = n % 2;
                n = n / 2;
                rev = rev * 10 + rem;
                if (rem == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
