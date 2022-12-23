using Service.Services.Utility.Lists;
using ShopCenter.Controller;
using System;

namespace ShopCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //BaseEntityniz var. Icersinde bir Id var, onu hersey ucun istifade  edin.
            //            ShopCenter classiniz var:
            //            Icherisinde liberaryleri saxlayan bir arrayimiz var. Bunun uchun indexleme etmelisiniz.

            //Liberary classiniz var.Namesi ve IsDeleted propertyleri var.Ve Booklari ozunde
            //saxlayan bir arrayi var
            //Liberary classininda Book ucun indexleme edirsiniz.

            //Book classiniz var.Name,Price,Genre,Author Propertyleriniz var.
            //      Book tipinden yaratdigim objectlerin qiymetlerini book.priceden istifade etmeden
            //muqayise ede bilmeliyem

            //  ProductList adinda generic bir custom list yaradirsiniz.
            //Bu listinize string ,int kimi deyerler toplusu yox sadece productlarinizi yiga
            //bilmelisiniz.

            //Bu Listiniz ucun Custom bir insert metodu yazirsiniz.
            //Ve yazdiginiz bu metodda yaranan problemler ucun oz yaratdiginiz custom
            //exceptionlari
            // istifade edirsiniz.

            //Ekran acilanda Optionlariniz var:
            //1.Show All Liberaries
            //2.Show All Books with liberary 
            //3.Remove liberary
            //ekranda gosterildikden sonra sizden uygun melumatlari isteyen metodlar
            // yazmalisiniz.
            #endregion

            ShopCenterController shopCenterController = new ShopCenterController();
            shopCenterController.GetAllOptions();
            
            
        }
    }
}
