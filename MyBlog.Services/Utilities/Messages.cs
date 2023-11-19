using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Services.Utilities
{
    public static class Messages
    {
        public static class General
        {
            public static string UnKnownError()
            {
                return "Bilinmeyen bir hata ile karşılaşıldı";
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="isPlural"></param>
            /// <param name="entityName"></param>
            /// <returns>$"Böyle bir {entityName} bulunamadı" şeklinde bir ifade dönecektir</returns>
            public static string NotFound(bool isPlural, string entityName)
            {
                if (isPlural) { return $"Hiçbir {entityName} bulunamadı"; }
                else { return $"Böyle bir {entityName} bulunamadı"; }
            }
            public static string NotFound(bool isPlural, string entityName, string process)
            {
                if (isPlural) { return $"Hiçbir {entityName} {process}"; }
                else { return $"Böyle bir {entityName} {process}"; }
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="isPlural"></param>
            /// <param name="entityName"></param>
            /// <returns>$"{name} adlı {entityName} başarıyla {process}." şeklinde bir ifade dönecektir</returns>
            public static string GiveMessage(string name, string entityName, string process )
            {
                return $"{name} adlı {entityName} başarıyla {process}.";
            }
            public static string GiveGeneralMessage(string name, string entityName, string process)
            {
                return $"{name} {entityName} başarıyla {process}.";
            }
            public static string TableNotFound(string entityName)
            {
                return $"{entityName} Adlı Tablo Getirilemedi.";
            }
        }
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) { return "Hiçbir kategori bulunamadı"; }
                else { return "Böyle bir kategori bulunamadı"; }
            }
            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} Adlı kategori başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} Adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} Adlı kategori kalıcı olarak başarıyla silinimiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} Adlı kategori aktif hale getirilmiştir.";
            }
        }
        public static class Article
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Makaleler Bulunamadı";
                else { return "Böyle bir makale bulunamadı"; }
            }
            public static string Add(string articleName)
            {
                return $"{articleName} adlı makale başarıyla silinmiştir.";
            }
            public static string Update(string articleName)
            {
                return $"{articleName} Adlı makale başarıyla güncellenmiştir.";
            }
            public static string Delete(string articleName)
            {
                return $"{articleName} Adlı makale başarıyla silinmiştir.";
            }
            public static string HardDelete(string articleName)
            {
                return $"{articleName} Adlı makale kalıcı olarak başarıyla silinimiştir.";
            }
            public static string UndoDelete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla arşivden geri getirilmiştir.";
            }
        }
        public static class Comment
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir yorum bulunamadı.";
                return "Böyle bir yorum bulunamadı.";
            }

            public static string Approve(int commentId)
            {
                return $"{commentId} no'lu yorum başarıyla onaylanmıştır.";
            }
            public static string Add(string createdByName)
            {
                return $"Sayın {createdByName}, yorumunuz başarıyla eklenmiştir.";
            }

            public static string Update(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla güncellenmiştir.";
            }
            public static string Delete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla silinmiştir.";
            }
            public static string HardDelete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla veritabanından silinmiştir.";
            }
            public static string UndoDelete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla arşivden geri getirilmiştir.";
            }
        }
    }
}
