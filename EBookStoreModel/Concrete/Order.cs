using EBookStoreCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreModel.Concrete
{
    public class Order:BaseEntity,IEntity
    {

        public DateTime OrderDate { get; set; }
        public Payment Payment { get; set; }
        public Decimal Price { get; set; }
        public int Stok { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public ICollection<OrderList> OrderLists { get; set; }
    }
}
