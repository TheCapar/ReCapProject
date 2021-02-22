using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            return new SuccessResult(Messages.KullanıcıEklendi);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.KullanıcıEklendi);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new DataResult<List<User>>(_userDal.GetAll(), true,"Başarıyla Listelendi");
        }

        public IDataResult<User> GetById(int userId)
        {
            return new DataResult<User>(_userDal.Get(u=>u.UserId == userId),true,"Başarıyla Kullanıcı Listelendi");
        }

        public IResult Upgrade(User user)
        {
            return new SuccessResult(Messages.KullanıcıEklendi);
        }
    }
}
