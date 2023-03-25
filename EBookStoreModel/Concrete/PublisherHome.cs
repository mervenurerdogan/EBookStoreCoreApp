using EBookStoreCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Concrete
{
    public class PublisherHome:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int  CityID { get; set; }
        public virtual City City { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
