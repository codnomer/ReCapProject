using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rent;

        public RentalManager(IRentalDal rent)
        {
            _rent = rent;
        }

        public IResult Add(Rental rental)
        {
            _rent.Add(rental);
            return new SuccessResult(Messages.AddingRental);
        }

        public IResult Delete(Rental rental)
        {
            _rent.Delete(rental);
            return new SuccessResult(Messages.DeleteRental);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rent.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDto()
        {
            if (DateTime.Now.Hour == 24)
            {
                return new ErrorDataResult<List<RentalDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<RentalDetailDto>>(_rent.GetRentalDto(), Messages.RentDetailMessage);
        }

        public IResult Uptate(Rental rental)
        {
            _rent.Update(rental);
            return new SuccessResult(Messages.UpdateRental);
        }
    }
}
