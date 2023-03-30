using EBookStoreBusiness.Abstract;
using EBookStoreBusiness.Concrete;
using EBookStoreDataAccess.Abstract;
using EBookStoreDataAccess.Concrete;
using EBookStoreDataAccess.Concrete.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreBusiness.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<EBookStoreContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();//ilişki kesildğinde scopped yapısıda kendisini kapatır
            
            serviceCollection.AddScoped<ICategoryService, CategoryService>();
            serviceCollection.AddScoped<IBookService, BookService>();
            serviceCollection.AddScoped<IUserService, UserService>();

            return serviceCollection;
            
        }
    }
}
