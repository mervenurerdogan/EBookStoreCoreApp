using EBookStoreCore.Concrete.EntityFramework;
using EBookStoreModel.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Concrete.Repository
{
    public class EfOrderRepository : EfEntityRepositoryBase<Order>
    {
        public EfOrderRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
