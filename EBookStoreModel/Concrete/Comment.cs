using EBookStoreCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Concrete
{
    public class Comment:BaseEntity,IEntity
    {
        public string Text { get; set; }
        public DateTime CommentAddDate { get; set; }

        //Foreign Key
        public int BookID { get; set; }
        public Book Book { get; set; }

        public int UserID { get; set; }
        public User User{ get; set; }
    }
}
