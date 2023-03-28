using EBookStoreBusiness.Abstract;
using EBookStoreCore.Utilities.Results.Abstract;
using EBookStoreCore.Utilities.Results.Concrete;
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
    public class UserService : IUserService
    {

        private readonly UnitOfWork _unitOfWork;

        public UserService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IResult> Add(UserAddDto userAddDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int userID)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<User>> Get(int userID)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<User>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<User>>> GetAllByNonDeleted()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<BookListDto>> GetAllByNonDeletedAndActive()
        {
            throw new NotImplementedException();
        }

        public  Task<IDataResult<IList<User>>> GetAllByRole(int roleID)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int userID)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(UserUpdateDto userUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
