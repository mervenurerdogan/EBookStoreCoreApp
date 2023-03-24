using EBookStoreCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Concrete
{
    public class User:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserImage { get; set; }

        //Foreign Key
        public int RoleID { get; set; }
        public Role Role { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
