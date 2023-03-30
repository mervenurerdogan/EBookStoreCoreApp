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
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryID);
        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActived();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();//silinmemiş olan kategorilerin hepsini getir
        Task<IResult> Add(CategoryAddDto categoryAddDto);//veri ekleme işlemimde IResult döenecek ve fronted kısmını entityleri gelecek yani Dto sınıfından
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto);
        Task<IResult> Delete(int categoryID);
        Task<IResult> HardDelete(int categoryID);
    }
}
