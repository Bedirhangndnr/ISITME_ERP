using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyBlog.Shared.Entities.Concrete;
using NToastNotify;
// BU SAYFADA OLUŞTURDUĞUMUZ, KENDİ FİLTREMİZİ PROGRAM.CS DOSYASINDA ADDCONTROLLERSVİTHVİEWS İLE EKLEYEREK ENTEGRE ETTİK.
// Burada yapılan işlemler site ziyaretçilerinin göreceği sayfalar ile ilgili olacak.
// BLOG SİTESİNİN TASARIMIYLA BİRLİKTE BURAYA DÖNÜLECEK.
namespace MyBlog.Mvc.Filters
{
    public class MvcExceptionFilter:IExceptionFilter
    {
        // Hangi ortamda çalışıyoruz? 
        private readonly IHostEnvironment _environment;
        // 
        private readonly IModelMetadataProvider _metadataProvider;
        private readonly ILogger _logger;
        private readonly IToastNotification _toastNotification;

        public MvcExceptionFilter(IHostEnvironment environment, IModelMetadataProvider metadataProvider, ILogger<MvcExceptionFilter> logger, IToastNotification toastNotification)
        {
            _environment = environment;
            _metadataProvider = metadataProvider;
            _logger = logger;
            _toastNotification = toastNotification;
        }

        public void OnException(ExceptionContext context)
        {
            // gerçek ortamda çalışıldığında is production olmalı. *****************************************************
            if (_environment.IsDevelopment())
            {
                // Hata reaksiyonllarını BİZ belirleyeceğiz.
                context.ExceptionHandled = true;
                var mvcErrorModel = new MvcErrorModel();
                ViewResult result;
                switch (context.Exception)
                {
                    case SqlNullValueException:
                        _toastNotification.AddSuccessToastMessage("asdasdasdas", new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        mvcErrorModel.Message =
                            $"Üzgünüz, işleminiz sırasında beklenmedik bir veritabanı hatası oluştu. Sorunu en kısa sürede çözeceğiz.";
                        // Bir view result döneceğiz ve bu view modelimizi ve mesajını oluşturduk
                        mvcErrorModel.Detail = context.Exception.Message;
                         result= new ViewResult { ViewName = "Error" };
                        result.StatusCode = 500;
                        _logger.LogError(context.Exception,context.Exception.Message);
                        break;
                    case NullReferenceException:
                        mvcErrorModel.Message =
                            $"Üzgünüz, işleminiz sırasında beklenmedik bir null veriye rastlandı. Sorunu en kısa sürede çözeceğiz.";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 403;
                        _logger.LogError(context.Exception, context.Exception.Message);
                        break;
                    default:
                        mvcErrorModel.Message =
                            $"Üzgünüz, işleminiz sırasında beklenmedik bir hata oluştu. Sorunu en kısa sürede çözeceğiz.";
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 500;
                        _logger.LogError(context.Exception, "Bu benim log hata mesajım!");
                        break;
                }

                result.ViewData = new ViewDataDictionary(_metadataProvider, context.ModelState);
                // view resultta kullanmak istediğimiz modelin eklenmesi
                result.ViewData.Add("MvcErrorModel",mvcErrorModel);
                // kullanıcıya dönecek result kendi oluşturduğumuz result ile atamış, değiştirmiş olduk.
                context.Result = result;
            }
        }
    }
}
