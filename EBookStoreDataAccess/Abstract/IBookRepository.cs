using EBookStoreCore.Data.Abstract;
using EBookStoreModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Abstract
{
    public interface IBookRepository : IEntityRepository<Book>
    {
        Task GetAllAsync(Func<Book, bool> value1, bool v, Func<Book, object> value2, Func<Book, object> value3);
    }
}
