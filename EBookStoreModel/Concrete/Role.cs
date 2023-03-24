using EBookStoreCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreModel.Concrete
{
    public class Role:BaseEntity, IEntity
    {
        public Roles Roles { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
