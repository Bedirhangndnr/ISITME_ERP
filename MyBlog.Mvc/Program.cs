﻿using Microsoft.AspNetCore.Http.Features;
using MyBlog.Mvc.AutoMapper.Profiles;
using MyBlog.Mvc.Halpers.Abstract;
using MyBlog.Mvc.Helpers.Concrete;
using MyBlog.Services.AutoMapper.Profiles;
using MyBlog.Services.Extensions;
using MyBlog.Mvc.Filters;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.Razor;
using MyBlog.Entities.Concrete;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// AddAsync services to the container.
builder.Services.AddRazorPages();
builder.Services.ConfigureApplicationCookie(options => { });
builder.Services.AddControllersWithViews(options=> {
    options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(value => "Bu alan boş geçilemez");
    options.Filters.Add<MvcExceptionFilter>();

}).AddRazorRuntimeCompilation().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve; // bu işlem şu an buglı çalışıyor. ilerleyen dönemlerden bu g çözülürse kullanılabilir.
}).AddNToastNotifyToastr(); // Eklendi

builder.Services.AddSession();
builder.Services.AddAutoMapper(typeof(PaymentProfile),typeof(CategoryProfile), typeof(ArticleProfile), typeof(UserProfile),
    typeof(ViewModelsProfile), typeof(CommentProfile), typeof(CustomerProfile), typeof(PaymentTypeProfile),
    typeof(CustomerTypeProfile), typeof(EmployeeProfile), typeof(EmployeeTypeProfile), typeof(CustomerReferanceProfile),
    typeof(NotificationProfile),typeof(AppointmentTypeProfile),typeof(SaleStatusProfile),typeof(SaleTypeProfile), 
    typeof(ProductGroupProfile), typeof(ProductSubGroupProfile),typeof(ProductProfile), typeof(SaleProfile), typeof(ProgramsProfile),
    typeof(AssociatedInstitutionsProfile), typeof(AppointmentProfile), typeof(ExpenseProfile)); // Eklendi

// Eklendi // mvc katmanı ile diğer katmanlar arasında köprü görevi görür
var Configuration = builder.Configuration;
builder.Services.LoadMyServices(connectionString: Configuration.GetConnectionString("LocalDb"));

// sevis kaydedilmeli
    builder.Services.AddScoped<IImageHelper, ImageHelper>();
    builder.Services.Configure<FormOptions>(options =>options.ValueCountLimit= 10000);
//builder.Services.AddControllers(mvcoptions => mvcoptions.ValueProviderFactories().)

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = new PathString("/Admin/User/Login");
    options.LogoutPath = new PathString("/Admin/User/Logout");
    options.Cookie = new CookieBuilder
    {
        Name = "MyBlog",
        // Herhangi bir kullanıcının javascript üzerinden cookie bilgilerine erişmesini engeller
        HttpOnly = true,
        // Cross site request forgery(csrf) sahtekarlığını engellemek için -> notion notlarında detayllı açıklaması var.
        // Saldırganın verdiği cookie bilgilerini direkt kabul etmeyi engeller ve sadeece kendi sitemizden gelen cookieleri kabul eder 
        SameSite = SameSiteMode.Strict,
        //profesyonel projelerde daima always olmalıdır.
        //cookie nin güvenlik değerini verme işlemi.
        SecurePolicy = CookieSecurePolicy.SameAsRequest
    };
    // kullanıcı siteye girşi yaptıktan sonra tanınan süre içerisinde kullanıcnın siteye tekrar giriş yapması gerekmez.
    // SlidingExpiration değerini tru yaptığımızda, kullanıcı, verilen belirlenen gün sayısı tamamlanmadan tekrar giriş yaparsa 
    // yine belirlenen gün sayısı kadar giriş yapmasının gerekmemesini sağlamak. örneğin 7 gün olarak belirlenen bir kullanıcı
    // 5. gün yine giriş yaparsa kalan 2 gün 7 güne geri uzar.
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = System.TimeSpan.FromDays(7);
    //giriş yapan fakat yetkisi olmayan bir yere giriş yapan kullanıcı için.
    //options.
    options.AccessDeniedPath = new PathString("/Admin/User/AccessDenied/"); // burası açılacak

});

builder.Services.AddControllersWithViews(option=> option.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(_ => "Bu alan boş geçilemez."));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseStatusCodePages();// eklendi hatalarda uyarı 404-501-500
    app.UseExceptionHandler(errorApp =>
    {
        errorApp.Run(async context =>
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "text/html";

            await context.Response.WriteAsync("<html><body>\r\n");
            await context.Response.WriteAsync("<h1>Unexpected Error</h1>\r\n");
            var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
            if (exceptionHandlerPathFeature?.Error != null)
            {
                // Loglama yapmak için burada exception'ı kaydedebilirsiniz.
                await context.Response.WriteAsync("<p>" + exceptionHandlerPathFeature.Error.Message + "</p>\r\n");
            }
            await context.Response.WriteAsync("</body></html>\r\n");
            await context.Response.WriteAsync(new string(' ', 512)); // IE padding
        });
    });
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseNToastNotify();
app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
            name: "Admin",
            areaName: "Admin",
            pattern: "Admin/{controller=Home}/{action=Index}/{id?}" // buradaki soru işareti id nin nullable olduğuna işaret eder.
            );
});
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute()); // varsayılan olarak homecontroller ve index sayfalarına gidecek.
// blog-> home sayfasında blog bilgilerini admin->home sayfasında admin home bilgilerini görmek için.
app.UseAuthorization();
app.MapRazorPages();
app.Run();
