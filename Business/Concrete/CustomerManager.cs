using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConserns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _cust;

        public CustomerManager(ICustomerDal cust)
        {
            _cust = cust;
        }

        public IResult Add(Customers customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _cust.Add(customer);

            return new SuccessResult(Messages.AddingCustomer);
            
        }

        public IResult Delete(Customers customer)
        {
            _cust.Delete(customer);
            return new SuccessResult(Messages.DeleteCustomer);
        }

            public IDataResult<List<CustomerDetailDto>> GetAll()
            {
            return new SuccessDataResult<List<CustomerDetailDto>>(_cust.CustomerDetailDto(), Messages.CustomerListed);
            }

            public IDataResult<Customers> GetById(int customerId)
            {
            var result = _cust.Get(p => p.UserId == customerId);
            if (result == null)
            {
                return new ErrorDataResult<Customers>(Messages.CustomerErrorGetByUserId);
            }
            return new SuccessDataResult<Customers>(result, Messages.CustomerSuccessGetByUserId);
        }

            public IResult Uptate(Customers customer)
            {
                _cust.Update(customer);
                return new SuccessResult(Messages.UpdateCustomer);
            }
        }
    }

