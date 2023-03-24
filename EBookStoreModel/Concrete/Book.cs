using EBookStoreCore.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreModel.Concrete
{
    public class Book:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Language { get; set; }
        public Condition Condition { get; set; }
        public Status Status { get; set; }
        public int Stock { get; set; }
        public int PublishYear { get; set; }
        public string Description { get; set; }
        public string BookImage { get; set; }

        public int CategoryID { get; set; }
        public int PublisherHomeID { get; set; }
     

        public virtual Category Category { get; set; }
        public virtual PublisherHome PublisherHome { get; set; }

        public ICollection<BookAuthor>  Authors { get; set; }//many to many 
        public ICollection<OrderList> Orders { get; set; }//many to many

        public ICollection<OrderList> OrderLists { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
