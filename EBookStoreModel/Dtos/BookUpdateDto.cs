using EBookStoreCore.Entities.Abstract;
using EBookStoreModel.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreModel.Dtos
{
    public class BookUpdateDto:DtoGetBase
    {
        [Required]
        public int ID { get; set; }

        [DisplayName("Kitap Adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MaxLength(250, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Desciption { get; set; }
        [DisplayName("Kitabın Ücreti")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MaxLength(6, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public Decimal Price { get; set; }
        [DisplayName("Kitabın Yazım Dili")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string Language { get; set; }

        [DisplayName("Stok")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public int Stok { get; set; }

        [DisplayName("Sayfa Sayısı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public int NumberofPages { get; set; }
        [DisplayName("Basım Yılı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/YYYY}")]
        public DateTime PublisYear { get; set; }

        [DisplayName("Kullanılmışlık Şartı ")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public Condition Condition { get; set; }

        [DisplayName("Kullanılmışlık Durumu ")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public Status Status { get; set; }

        [DisplayName("Kitap Kategori ")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public int categoryID { get; set; }
        public Category Category { get; set; }

        [DisplayName("Kitap Yayınevi ")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public int PublisherHomeID { get; set; }
        public PublisherHome PublisherHome { get; set; }
        [DisplayName("Aktif mi? ")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public bool IsActive { get; set; }
        [DisplayName("Silinsin mi? ")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir...")]
        public bool IsDeleted { get; set; }

    }
}
