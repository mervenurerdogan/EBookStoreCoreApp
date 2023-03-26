using EBookStoreBusiness.Abstract;
using EBookStoreCore.Utilities.Results.Abstract;
using EBookStoreCore.Utilities.Results.Concrete;
using EBookStoreDataAccess.Abstract;
using EBookStoreModel.Concrete;
using EBookStoreModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreBusiness.Concrete
{
    public class BookService : IBookService
    {

        public readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IResult> Add(BookAddDto bookAddDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int bookID)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<BookDto>> Get(int bookID)
        {
            var book = await _unitOfWork.Books.GetAsync(b => b.ID == bookID,b=>b.PublisherHome,b=>b.Category);
            if (book!=null)
            {
                return new DataResult<BookDto>(ResultStatus.Success, new BookDto
                {
                    Book = book,
                    ResultStatus = ResultStatus.Success,
                });
                  
            }

            return new DataResult<BookDto>(ResultStatus.Error, "Böyle bir kitap bulunamadı", null);
        }

        public async Task<IDataResult<BookListDto>> GetAll()
        {
            var books=await _unitOfWork.Books.GetAllAsync(null,b=>b.Category,b=>b.PublisherHome);

            if (books.Count > -1)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    ResultStatus= ResultStatus.Success,
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, "Bu kitaplar bulunamadı", null);
        }

        public async Task<IDataResult<BookListDto>> GetAllByCategory(int categoryID)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.ID == categoryID);//Category ıd var mı kontrol ediyoruz
            if (result)
            {
                var books = await _unitOfWork.Books.GetAllAsync(b => b.CategoryID == categoryID && b.IsDeleted == false && b.IsActive == true, bc => bc.Category, bc => bc.PublisherHome);
                if (books.Count > -1)
                {
                    return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                    {
                        Books = books,
                        ResultStatus = ResultStatus.Success,
                    });
                }
                return new DataResult<BookListDto>(ResultStatus.Error, "Bu kitaplar bulunamadı", null);
            }
            return new DataResult<BookListDto>(ResultStatus.Error, "Bu kategori  bulunamadı", null);

        }

        public async Task<IDataResult<BookListDto>> GetAllByNonDeleted()
        {
            var books = await _unitOfWork.Books.GetAllAsync(b => b.IsDeleted == false, bc => bc.Category, bc => bc.PublisherHome);
            if (books.Count > -1)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books = books,
                    ResultStatus = ResultStatus.Success,
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, "Bu kitaplar bulunamadı", null);
        }

        public  async Task<IDataResult<BookListDto>> GetAllByNonDeletedAndActive()
        {
            var books= await _unitOfWork.Books.GetAllAsync(b=>b.IsActive==true&&b.IsDeleted==false,bc=>bc.Category,bc=>bc.PublisherHome);
            if(books.Count > -1)
            {
                return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                {
                    Books=books,
                    ResultStatus=ResultStatus.Success,
                });
            }
            return new DataResult<BookListDto>(ResultStatus.Error, "Bu kitaplar bulunamadı", null);

        }

        public Task<IDataResult<BookListDto>> GetAllByPublisherHome(int publisherHomeID)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int bookID)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(BookUpdateDto bookUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
