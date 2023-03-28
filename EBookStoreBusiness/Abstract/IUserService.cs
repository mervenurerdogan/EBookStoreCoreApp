using EBookStoreCore.Utilities.Results.Abstract;
using EBookStoreCore.Utilities.Results.Concrete;
using EBookStoreModel.Concrete;
using EBookStoreModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreBusiness.Abstract
{
    public interface IUserService
    {

        Task<IDataResult<User>> Get(int userID);
        Task<IDataResult<IList<User>>> GetAll();
        Task<IDataResult<IList<User>>> GetAllByNonDeleted();
        Task<IDataResult<IList<User>>> GetAllByRole(int roleID);
        Task<IDataResult<BookListDto>> GetAllByNonDeletedAndActive();//silinmemiş ve aktif olan userları getir admin sayfasında bu metod şartına uyanları listeliyceğiz
        Task<IResult> Add(UserAddDto userAddDto);
        Task<IResult> Update(UserUpdateDto  userUpdateDto);
        Task<IResult> Delete(int userID);
        Task<IResult> HardDelete(int userID);
        
    }
}
