using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        internal static string ProductsListed="kayıtlar Listelendi";
        internal static string ProductAdded="Veri Eklendi";
        internal static IResult ProductLoad;
        internal static string ProductUpdated="Ürün Güncellendi";
        internal static string ProductDeleted="Ürün Başarıyla Silindi";
        internal static string GetProductById="Id ye göre ürün bulundu";
        internal static string Fail="İşlem Başarısız oldu";
        internal static string RentalAdded="Araba kiralandı";
        internal static string RentalListed="Kiralık Arabalar Listelendi";
    }
}
