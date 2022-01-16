using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.Core.Shared.Constants
{
    public class Messages
    {
        public const string Unsuccessful = "Başarısız";
        public const string Successful = "Başarılı";
        public const string Inserted = "Kayıt eklendi.";
        public const string InsertedFail = "Veritabanına kayıt eklenirken hata oluştu.";
        public const string NotInserted = "Veritabanına kayıt eklenmedi.";
        public const string Modified = "Kayıt güncellendi.";
        public const string ModifiedFail = "Veritabanında kayıt güncellenirken hata oluştu.";
        public const string NotModified = "Veritabanında kayıt güncellenmedi.";
        public const string DataAlreadyExistsInTheSystem = "Kayıt zaten sistemde mevcuttur.";
        public const string DatabaseQueryError = "veritabanı sorgulama hatası";
        public const string NotFound = "Kayıt bulunamadı";
        public const string HttpRequestError = "Http istek hatası";
        public const string EmailSendError = "E-posta gönderme hatası";
        public const string FileCreateError = "Dosya oluşturma hatası";
        public const string FileDeleteError = "Dosya silme hatası";
    }
}
