using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Entities.Concrete;
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
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new DataResult<List<User>>(_userDal.GetAll(), true, "Başarıyla Listelendi");
        }

        public IDataResult<User> GetById(int userId)
        {
            return new DataResult<User>(_userDal.Get(u => u.Id == userId), true, "Başarıyla Kullanıcı Listelendi");
        }

        public IResult Update(User user)
        {
            return new SuccessResult(Messages.UserAdded);
        }
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }
        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Email == email));
        }
    }
}
