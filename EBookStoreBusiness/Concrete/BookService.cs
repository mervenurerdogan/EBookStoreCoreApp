using AutoMapper;
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

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


       

        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Add(BookAddDto bookAddDto)
        {
            var book=_mapper.Map<Book>(bookAddDto);
            await _unitOfWork.Books.AddAsync(book).ContinueWith(t=>_unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{bookAddDto.Name} adlı kitap başarı ile eklendi");
        }

        public async Task<IResult> Delete(int bookID)
        {
            var result = await _unitOfWork.Books.AnyAsync(b => b.ID == bookID);
            if (result)
            {
                var book=await _unitOfWork.Books.GetAsync(b=>b.ID==bookID);
                book.IsDeleted = true;
                await _unitOfWork.Books.UpdateAsync(book).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{book.Name} isimli kitap silinmiştir");


            }

            return new Result(ResultStatus.Error, "böyle bir kitap bulunamadı");
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
        public async Task<IDataResult<BookListDto>> GetAllByCategory(int categoryID)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.ID == categoryID);//Category ıd var mı kontrol ediyoruz
            if (result)
            {
                var books = await _unitOfWork.Books.GetAllAsync(b => b.CategoryID == categoryID && b.IsDeleted == false && b.IsActive == true,
                    bc => bc.Category, bc => bc.PublisherHome);
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

        public async Task<IDataResult<BookListDto>> GetAllByPublisherHome(int publisherHomeID)
        {
            var result=await _unitOfWork.PublisherHomes.AnyAsync(p=>p.ID == publisherHomeID);//publisherhome ıd var mı 
            if (result)
            {
                var books=await _unitOfWork.Books.GetAllAsync(b=>b.PublisherHomeID== publisherHomeID&&b.IsDeleted==false&&b.IsActive==true,bp=>bp.Category,bp=>bp.PublisherHome);
                if(books.Count > -1)
                {
                    return new DataResult<BookListDto>(ResultStatus.Success, new BookListDto
                    {
                        Books = books,
                        ResultStatus = ResultStatus.Success,
                    });
                }

                return new DataResult<BookListDto>(ResultStatus.Error, "Bu kitaplar bulunamadı", null);
            }
            return new DataResult<BookListDto>(ResultStatus.Error, "Bu basım evi  bulunamadı", null);
        }

        public async Task<IResult> HardDelete(int bookID)
        {
            var result = await _unitOfWork.Books.AnyAsync(b => b.ID == bookID);
            if(result)
            {
                var book = await _unitOfWork.Books.GetAsync(b=>b.ID==bookID);
                await _unitOfWork.Books.DeleteAsync(book).ContinueWith(t => _unitOfWork.SaveAsync());

                return new Result(ResultStatus.Success, $"{book.Name} adlı kitap veritabanından silindi");

            }

            return new Result(ResultStatus.Error, "Böyle bir kitap bulunamadı");
        }

        public async Task<IResult> Update(BookUpdateDto bookUpdateDto)
        {
            var book = _mapper.Map<Book>(bookUpdateDto);
            await _unitOfWork.Books.UpdateAsync(book).ContinueWith(t => _unitOfWork.SaveAsync());

            return new Result(ResultStatus.Success, $"{bookUpdateDto.Name} adlı kitap başarıyla güncellenmiştir.");
            
         
        }
    }
}
