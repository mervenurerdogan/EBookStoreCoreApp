
using EBookStoreBusiness.Abstract;
using EBookStoreBusiness.Concrete;
using EBookStoreBusiness.Extensions;
using EBookStoreDataAccess.Abstract;
using EBookStoreDataAccess.Concrete;
using EBookStoreDataAccess.Concrete.Context;
using EBookStoreDataAccess.Concrete.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();//her iþlem sonrasýn tekrar tekrar derlemeye gerek kalmýyor.Derleemden de kaydedilen deðiþiklikler görülebilir
builder.Services.AddAutoMapper(typeof(Program).Assembly);//derleme esnasýnda Automapper istenen classlarý taramýþ oluyor
builder.Services.LoadMyServices();

builder.Services.AddTransient<ICategoryService, CategoryService>().AddTransient<UnitOfWork>();

////builder.Services.AddTransient<ICategoryRepository, EfCategoryRepository>();
//builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
////builder.Services.AddTransient<IMapper, Mapper>();

//builder.Services.AddDbContext<EBookStoreContext>(options =>
//            options.UseSqlServer(builder.Configuration.GetConnectionString("NewConn")));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseStatusCodePages();//404 not found hatasýný verecek
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name:"Admin",
        areaName:"Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}"

        );
    endpoints.MapDefaultControllerRoute();
});

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
