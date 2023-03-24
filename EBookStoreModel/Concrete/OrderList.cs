using EBookStoreCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Concrete
{
    public class OrderList:BaseEntity,IEntity
    {
        public int BookID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public int TotalOrder { get; set; }

        public Book Book { get; set; }
        public Order Order { get; set; }
    }
}
