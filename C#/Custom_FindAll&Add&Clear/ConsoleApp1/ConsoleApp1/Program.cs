using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindAll Clear
            //List<string> systemList = new List<string>();
            //systemList.Add("nana");
            //systemList.Add("nicat");
            //systemList.Add("mahir");
            //systemList.Clear();
         
            //foreach (var item in systemList)
            //{
            //    Console.WriteLine(item);
            //}
            MyList<int> nums = new MyList<int>();
            nums.MyAdd(5);
            nums.MyAdd(25);
            nums.MyAdd(51);
            nums.MyClear();
            //var res = nums.MyFindAll(n => n > 10);
            foreach (var item in nums.list)
            {
                Console.WriteLine(item);
            }


        }

    }
    class MyList<T>
    {
        public T[] list;
        public MyList()
        {
            list = new T[0];
        }
        public void MyAdd(T obj)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = obj;
        }
        
        public MyList<T> MyFindAll(Predicate<T> predicate)
        {
            MyList<T> newList = new MyList<T>();
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    newList.MyAdd(item);
                }
            }
            return newList;
            
        }
        public void MyClear()
        {
            Array.Resize(ref list, 0);

        }
    }
}
