using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class LiberaryService : ILiberaryService
    {
        public void RemoveLiberary(string libName)
        {
            var liberaries = GetAll();
            foreach (var lib in liberaries)
            {
                if (lib.Name.ToUpper()==libName.ToUpper())
                {
                    lib.IsDeleted = true;
                }
            }
        }
        public void ShowAllLiberaries()
        {
            var liberaries = GetAll();
            foreach (var lib in liberaries)
            {
                if (lib != null&&lib.IsDeleted==false)
                {
                    Console.WriteLine(lib.Name);
                }
            }

        }
        private Liberary[] GetAll()
        {
            ShopCenter shop = new ShopCenter(2);
            Liberary lib1 = new Liberary("Axundov", 10);
            Liberary lib2 = new Liberary("Libraff", 20);
            shop[0] = lib1;
            shop[1] = lib2;
       
            return shop.liberaries;
        }
    }
}
