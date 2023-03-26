using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IAuthorRepository Authors { get; }
        IBookRepository Books { get; }
        IBookAuthorRepository BookAuthors { get; }
        ICategoryRepository Categories { get; }
        ICityRepository Cities { get; }
        ICommentRepository Comments { get; }
        IOrderListRepository OrderLists { get; }
        IOrderRepository Orders { get; }
        IPublisherHomeRepository PublisherHomes { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }

        Task<int> SaveAsync();

        //_unitofwork.Categories.AddAsync() şeklinde kullanım sağlayacağız
        //_unitofwork.Books.AddAsync(book);
        //_unitofwork.Categories.AddAsync(category);
        //_unitofwork.SaveAsync();
        //tek bir save ile kaydetmiş oluyoruz

    }
}
