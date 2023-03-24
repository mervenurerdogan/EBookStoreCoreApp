using EBookStoreCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Concrete
{
    public  class Author:BaseEntity,IEntity
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string EMail { get; set; }

        public ICollection<BookAuthor> Books { get; set; }
    }
}
