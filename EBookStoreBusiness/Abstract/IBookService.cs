using EBookStoreCore.Utilities.Results.Abstract;
using EBookStoreModel.Concrete;
using EBookStoreModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreBusiness.Abstract
{
    public interface IBookService
    {
        Task<IDataResult<BookDto>> Get(int bookID); //asıl entityleri frented kısmında açmayacağız o yüzden dto ile bu kısmı göndereceğiz
        Task<IDataResult<BookListDto>> GetAll();
        Task<IDataResult<BookListDto>> GetAllByNonDeleted();//silinmemiş olan kitapların hepsini getir
        Task<IDataResult<BookListDto>> GetAllByCategory(int categoryID);//Kategorisine göre getir
        Task<IDataResult<BookListDto>> GetAllByPublisherHome(int publisherHomeID);//yayınevine göre getir
        Task<IDataResult<BookListDto>> GetAllByNonDeletedAndActive();//silinmemiş ve aktif olan kitapları getir satış sayfasında bu metod şartına uyanları listeliyceğiz
        Task<IResult> Add(BookAddDto bookAddDto);//veri ekleme işlemimde IResult döenecek ve fronted kısmını entityleri gelecek yani Dto sınıfından
        Task<IResult> Update(BookUpdateDto bookUpdateDto);
        Task<IResult> Delete(int bookID);
        Task<IResult> HardDelete(int bookID);
    }
}
