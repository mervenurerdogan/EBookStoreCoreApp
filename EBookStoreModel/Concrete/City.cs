using EBookStoreCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Concrete
{
    public class City:BaseEntity,IEntity
    {

        public string Name { get; set; }
        public ICollection<PublisherHome> PublisherHomes { get; set; }
    }
}
