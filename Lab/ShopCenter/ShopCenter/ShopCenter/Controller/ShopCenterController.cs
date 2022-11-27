using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCenter.Controller
{
   public class ShopCenterController
    {
        public void GetAllOptions()
        {
            Console.WriteLine("1.Show All Liberaries");
            Console.WriteLine("2.Show books");
            Console.WriteLine("3.Remove liberary");
            int num = int.Parse(Console.ReadLine());
           
            switch (num)
            {
                case 1:
                    LiberaryService showLibService = new LiberaryService();
                    showLibService.ShowAllLiberaries();
                    break;
                case 2:
                    BookService showBookService = new BookService();
                    showBookService.GetAllBooks();
                    break;
                case 3:
                    RemovingLib();
                    break;
                default:
                    Console.WriteLine("We have not such option!");
                    break;
            }

        }
        public static void RemovingLib()
        {
            Console.WriteLine("Silmek istediyiniz liberarynin adini daxil edin");
           
            string name = Console.ReadLine();
            LiberaryService removeLib = new LiberaryService();
            removeLib.RemoveLiberary(name);

        }
        
    }
}
