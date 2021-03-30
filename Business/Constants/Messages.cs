using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //------------------CAR MANAGER CONSTANTS----------------------
        public static string InvalidLengthMessage = "Araba ismi uzunluğu geçersiz oldu.";
        public static string PriceWarning = "Girilen fiyat geçersizdir.";
        public static string CarMessage = "Araba ekleme işlemi başarıyla gerçekleşti.";
        public static string DeleteCarMessage = "Araba silme işlemi başarıyla gerçekleşti.";
        public static string GettingMessage= "Getirme fonksiyonu başarıyla gerçekleşti.";
        public static string DetailMessage = "Dto çalışması gerçekleşti.";
        public static string UptatedMessage="Güncelleme gerçekleşti.";
        public static string ColorMessage = "Renk mesajı";


        //------------------BRAND MANAGER CONSTANTS-----------------------

        public static string AddingBrand = "Marka eklendi.";
        public static string UptatedBrand="Marka güncellendi.";
        internal static string DeleteBrand = "Marka silindi.";

        //------------------Color Manager Constants-----------------------
        public static string ColorAddMessage = "Renk eklemesi yapıldı.";
        public static string ColorDeleteMessage = "Renk silindi";
        public static string ColorUptateMessage ="Renk güncellendi";

    }
}
