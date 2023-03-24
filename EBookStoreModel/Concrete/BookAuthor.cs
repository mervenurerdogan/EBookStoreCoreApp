using EBookStoreCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Concrete
{
    public class BookAuthor:BaseEntity,IEntity
    {

        //Bir yazarın birden fazla kitabı,bir kitabın birden fazla yazarı olabilir

        public int BookID { get; set; }
        public int AuthorID { get; set; }

        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
