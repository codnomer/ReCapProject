using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConserns.Validation;
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

        IUserDal _user;

        public UserManager(IUserDal user)
        {
            _user = user;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(Users user)
        {
            
            _user.Add(user);
            return new SuccessResult(Messages.UserAdding);
        }

        public IResult Delete(Users user)
        {
            _user.Delete(user);
            return new SuccessResult(Messages.UserDelete);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_user.GetAll(), Messages.GettingUserMessage);
        }

        public IDataResult<Users> GetById(int userId)
        {
            return new SuccessDataResult<Users>(_user.Get(u => u.UserId == userId));
        }

        public IResult Uptate(Users user)
        {
            _user.Update(user);
            return new SuccessResult(Messages.UserUpdate);
        }
    }
}
