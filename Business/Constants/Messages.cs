using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarAdded = "Araba eklendi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarNotFound = "Araç bulunamadı";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarExists = "Araç zaten veritabanında var.";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandsListed = "Markalar listelendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorsListed = "Renkler listelendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalNotFound = "Kiralama bulunamadı";
        public static string CarImageAdded = "Araç resmi eklendi";
        public static string CarImageUpdated = "Araç resmi güncellendi";
        public static string CarImageDeleted = "Araç resmi silindi";
        public static string CarImageNotFound = "Resim bulunamadı";
        public static string CarImageExists = "Resim kaydı veritabanında var";
        public static string MaxCarImageCountLimit = "Bir aracın en fazla 5 resmi olabilir";
        public static string CarImageListed = "Resim(ler) listelendi";
        public static string RentalExists = "Kiralama kaydı veritabanında var";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
