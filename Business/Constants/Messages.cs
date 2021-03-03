using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "Kategorideki Ürün Sayısından Dolayı Eklenemiyor";

        public static string ProductNameAlreadyExists = "Bu İsimde Başka Bir Ürün Zaten Var";

        public static string CategoryLimitExceded = "Kategori Sayısı Daha Az Olmalı";

        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kullanıcı Kaydedildi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Mevcut";
        public static string AccessTokenCreated = "Access Token Oluşturuldu";
    }
}
