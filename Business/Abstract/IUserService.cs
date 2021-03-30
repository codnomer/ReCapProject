using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(Users user);
        IResult Delete(Users user);
        IResult Uptate(Users user);
        IDataResult<Users> GetById(int userId);
        IDataResult<List<Users>> GetAll();
    }
}
