using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
   public interface ILiberaryService
    {
        public void ShowAllLiberaries();
        public void RemoveLiberary(string libName);
    }
}
