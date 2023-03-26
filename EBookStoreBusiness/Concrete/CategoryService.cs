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
        public CategoryService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> Add(CategoryAddDto categoryAddDto)
        {
            await _unitOfWork.Categories.AddAsync(new Category
            {
                Name = categoryAddDto.Name,
                Description = categoryAddDto.Description,
                IsActive = categoryAddDto.IsActive,
                CreatedDate = DateTime.Now,
                IsDeleted = false

            }).ContinueWith(t => _unitOfWork.SaveAsync());
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

        public async Task<IDataResult<Category>> Get(int categoryID)
        {
          var category=  await _unitOfWork.Categories.GetAsync(c=>c.ID== categoryID,c=>c.Books);

          if(category!=null) 
            {
                return new DataResult<Category>(EBookStoreCore.Utilities.ClassEnum.ResultStatus.Success, category);
            }

            return new DataResult<Category>(ResultStatus.Error, "Böyle bir kategori bulunmadı", null);
        }

        public async Task<IDataResult<IList<Category>>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Books);
            if (categories.Count > -1) //-1 den büyükse kategorileri listele getir
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç bir kategori bulunmadı", null);
        }

        public async Task<IDataResult<IList<Category>>> GetAllByNonDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => c.IsDeleted == false, c => c.Books);
            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }

            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiçbir kategori bulunamadı", null);

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
            var category = await _unitOfWork.Categories.GetAsync(c => c.ID == categoryUpdateDto.ID);//update edilcek değeri çağırdık
            if (category != null)
            {
                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.IsActive = categoryUpdateDto.IsActive;
                category.IsDeleted = categoryUpdateDto.IsDeleted;
                await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());

                return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı  kategori başarı ile güncellendi");

            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı");
        }
    }
}
