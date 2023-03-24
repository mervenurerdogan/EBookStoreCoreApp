﻿using EBookStoreCore.Data.Abstract;
using EBookStoreModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Abstract
{
    public interface IBookAuthorRepository:IEntityRepository<BookAuthor>
    {
    }
}
