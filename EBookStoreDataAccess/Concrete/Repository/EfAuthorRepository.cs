using EBookStoreCore.Concrete.EntityFramework;
using EBookStoreCore.Entities.Abstract;
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
    public class EfAuthorRepository : EfEntityRepositoryBase<Author>, IAuthorRepository
    {
        public EfAuthorRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
