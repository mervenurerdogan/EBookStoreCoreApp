using EBookStoreCore.Data.Abstract;
using EBookStoreModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreDataAccess.Abstract
{
    internal interface IAuthorRepository:IEntityRepository<Author>
    {
    }
}
