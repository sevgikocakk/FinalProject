using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static deyince newlemiyoruz.Tek bir instance oluyor.
    //publicler PascalCase yazılır.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductsListed="Ürünler Listelendi.";
        public static string ProductCountOfCategoryError="Kategori hatası.";
        public static string ProductNameAlreadyExists="Bu isim zaten başkasında mevcut.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
