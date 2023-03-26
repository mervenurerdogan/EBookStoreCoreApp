using EBookStoreCore.Entities.Abstract;
using EBookStoreModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Dtos
{
    public class BookDto:DtoGetBase
    {

        public Book Book { get; set; }
    }
}
