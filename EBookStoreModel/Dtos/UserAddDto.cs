using EBookStoreModel.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Dtos
{
    public class UserAddDto
    {
        [DisplayName("Adınız")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Name { get; set; }
        [DisplayName("Soyadınız")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Surname { get; set; }
        [DisplayName("Kullanıcı Adınız")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MaxLength(20, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string UserName { get; set; }
        [DisplayName("Şifreniz")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MaxLength(10, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Password { get; set; }
        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MaxLength(11, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(11, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string PhoneNumber { get; set; }
        [DisplayName("Mail Adresi ")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public string EMail { get; set; }

        [DisplayName("Adres")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public string Address { get; set; }

        [DisplayName("Doğumgünü Tarihi")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/YYYY}")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Fotoğraf")]
       // [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
      
        public string UserImage { get; set; }
        [DisplayName("Kullanıcı Rolünü")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public int RoleID { get; set; }
        public Role Role { get; set; }

        [DisplayName("Kullanıcı aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]

        public bool IsActive { get; set; }


    }
}
