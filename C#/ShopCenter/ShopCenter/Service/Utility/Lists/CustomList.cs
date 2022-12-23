using Service.Utility.Exceptions;
using System;

namespace Service.Services.Utility.Lists
{
    public class CustomList<T>
    {
        public T[] list;
        public CustomList()
        {
            list = new T[0];
        }
      
        public void AddToList(T obj)
        {
          
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = obj;
        }

        public void Insert(int index, T obj)
        {
            Array.Resize(ref list, list.Length + 1);
            try
            {
                if (index < list.Length)
                {
                    for (int i = list.Length - 1; i >= index; i--)
                    {
                        list[i] = list[i - 1];
                        if (i == index)
                        {
                           list[i] = obj;

                        }
                    }
                }
                else
                {
                    throw new IndexOutOfBoundsException("Index out of bounds");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  
    }
}
}