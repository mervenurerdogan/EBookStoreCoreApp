﻿using EBookStoreCore.Concrete.EntityFramework;
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
    public class EfBookAuthorRepository : EfEntityRepositoryBase<BookAuthor>, IBookAuthorRepository
    {
        public EfBookAuthorRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
