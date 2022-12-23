using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Console.WriteLine(CheckNums(10));
            //int a = 10;
            //int b = 20;
            //Console.WriteLine(Print(a, b));
            //int[] array = { 1,10, 90,2,7,6,4,21};
            //Console.WriteLine(GetMaxValue(array));
            //Console.WriteLine(CountOfElements(array));
        }
        #region Task1

        //1.size bir n ededi gelir.cut olub olmadigini yoxlayin
        //eger cutdurse ekrana " n in kvadrati X ededidir" cixarin.
        //Sehvdirse "n tek ededdir "cixarsin


        //public static string CheckNums(int n)
        //{
        //    if (n == 0)
        //    {
        //        return "0 ne tek ne cutdur";

        //    }
        //    else if (IsEven(n))
        //    {
        //        return $"{n} ededinin kvadrati {n * n}";
        //    }

        //    else
        //    {
        //        return $"{n} tek ededdir";
        //    }
        //}
        //public static bool IsEven(int n)
        //{

        //    if (n % 2 == 0)
        //    {
        //        return true;
        //    }
        //    return false;

        //}
        #endregion

        #region Task2
        // 2.size a ve b ededleri verilib.a nin b den kicik oldugunu
        //yoxlamaq sherti ile
        //a dan b ye qeder olan ededleri ekrana yazdirin

        //public static string Print(int a,int b)
        //{
        //    string str = string.Empty;
        //    if (a>=b)
        //    {
        //        return "a b den kicik olmalidir";
        //    }
        //    else
        //    {
        //        for (int i = a; i <= b; i++)
        //        {
        //            str = str + " " + i;

        //        }
        //        return str;
        //    }

        //}
        #endregion

        #region Task3
        //3.bir array gelir.Bu arrayin elementlerinden cut ve 9 dan kicik olanlarin sayini tapin

        //public static int CountOfElements(int[] arr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (IsCorrect(arr[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        //public static bool IsCorrect(int num)
        //{
        //    if (num % 2 == 0 && num <= 9)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        #endregion

        #region Task4
 //        4.Bir array qebul edib geriye bu arrayin en boyuk elementini
 //qaytaran metod yazin.

        //public static int GetMaxValue(int[] arr)
        //{
        //    int max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i]>max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    return max;
        //}
        #endregion


    }
}
