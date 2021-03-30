using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService 
    {
        IResult Add(Customers customer);
        IResult Delete(Customers customer);
        IResult Uptate(Customers customer);
        IDataResult<Customers> GetById(int customerId);
        IDataResult<List<CustomerDetailDto>> GetAll();

    }
}
