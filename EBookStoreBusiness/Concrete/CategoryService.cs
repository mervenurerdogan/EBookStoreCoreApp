using AutoMapper;
using EBookStoreBusiness.Abstract;
using EBookStoreCore.Utilities.Results.Abstract;
using EBookStoreCore.Utilities.Results.Concrete;
using EBookStoreDataAccess.Abstract;
using EBookStoreDataAccess.Concrete;
using EBookStoreModel.Concrete;
using EBookStoreModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EBookStoreCore.Utilities.ClassEnum;

namespace EBookStoreBusiness.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryService(UnitOfWork unitOfWork,Mapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IResult> Add(CategoryAddDto categoryAddDto)
        {
            var category=_mapper.Map<Category>(categoryAddDto);
            await _unitOfWork.Categories.AddAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            // yada yukaırda task e devam ederek save edebiliriz await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{categoryAddDto.Name} kategori başarı ile eklendi");
        }

        public async Task<IResult> Delete(int categoryID)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.ID == categoryID);
            if (category != null)
            {
                category.IsDeleted = true;//artık silimiş oldu
                await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori başarı ile silindi..");
            }

            return new Result(ResultStatus.Error, "Kategori bulunmadı");
        }

        public async Task<IDataResult<CategoryDto>> Get(int categoryID)
        {
          var category=  await _unitOfWork.Categories.GetAsync(c=>c.ID== categoryID,c=>c.Books);

          if(category!=null) 
            {
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto
                {
                    Category=category,
                    ResultStatus=ResultStatus.Success,  
                });
            }

            return new DataResult<CategoryDto>(ResultStatus.Error, "Böyle bir kategori bulunmadı", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Books);
            if (categories.Count > -1) //-1 den büyükse kategorileri listele getir
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories=categories,
                    ResultStatus = ResultStatus.Success,
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunmadı", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => c.IsDeleted == false, c => c.Books);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success,new CategoryListDto
                {
                    Categories=categories,
                    ResultStatus = ResultStatus.Success,
                });
            }

            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiçbir kategori bulunamadı", null);

        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActived()
        {
           var categories =await _unitOfWork.Categories.GetAllAsync(c=>c.IsActive==true&&c.IsDeleted==false, c => c.Books);
            if(categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success,

                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiçbir kategori bulunamadı", null);

        }

        public async Task<IResult> HardDelete(int categoryID)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.ID == categoryID);
            if (category != null)
            {
                await _unitOfWork.Categories.DeleteAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori veritabanından başarı ile silindi");

            }

            return new Result(ResultStatus.Error, "Kategori bulunmadı");
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var category = _mapper.Map<Category>(categoryUpdateDto);
            await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı kategori başarı ile güncellendi");
        }
    }
}
