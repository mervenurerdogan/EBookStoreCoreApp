using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreModel.Dtos
{
    public class CategoryAddDto
    {

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [MaxLength(300, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Description { get; set; }
        [DisplayName("Kategori aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]

        public bool IsActive { get; set; }
    }
}
