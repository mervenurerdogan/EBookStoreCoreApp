using EBookStoreCore.Concrete.EntityFramework;
using EBookStoreDataAccess.Abstract;
using EBookStoreModel.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Concrete.Repository
{
    public class EfBookRepository : EfEntityRepositoryBase<Book>, IBookRepository
    {
        public EfBookRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Task GetAllAsync(Func<Book, bool> value1, bool v, Func<Book, object> value2, Func<Book, object> value3)
        {
            throw new NotImplementedException();
        }
    }
}
