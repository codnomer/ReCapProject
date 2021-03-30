using Entities.Concrete;
using Entities.DTOs;
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
        //------------------USER MANAGER-----------------------------
        public static string UserAdding = "Kullanıcı eklendi.";
        public static string UserDelete = "Kullanıcı silindi.";
        public static string UserUpdate = "Kullanıcı güncellendi";
        public static string GettingUserMessage = "Kullanıcalar getirildi.";
        //--------------------RENTAL MANAGER--------------------------
        public static string AddingRental = "Kiralama eklendi";
        public static string UpdateRental = "Kiralama güncellendi";
        public static string DeleteRental = "Kiralama silindi";
        public static string RentDetailMessage = "Kiralama detayları getirildi";
        public static string MaintenanceTime = "Bakım zamanı";
        //-------------------CUSTOMER MANAGER---------------
        public static string ErrorCustom = "Hatalı müşteri girişi";
        public static string AddingCustomer = "Müşteri eklendi";
        public static string DeleteCustomer = "Müşteri silindi";
        public static string UpdateCustomer = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi.";
        public static string CustomerSuccessGetByUserId = "UserId ye göre başarıyla listelendi";
        public static string CustomerErrorGetByUserId = "UserId ya göre başarısız listeleme gerçekleşti";
    }
}
