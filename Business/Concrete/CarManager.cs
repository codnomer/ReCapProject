using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class CarManager : ICarService
    {
        ICarDal _ıcar;

        public CarManager(ICarDal ıcar)
        {
            _ıcar = ıcar;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

            
            _ıcar.Add(car);
            return new SuccessResult(Messages.CarMessage);
            


        }

        public IResult Delete(Car car)
        {
            _ıcar.Delete(car);
            return new SuccessResult(Messages.DeleteCarMessage);
            
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_ıcar.GetAll(),Messages.GettingMessage);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_ıcar.GetCarDetailDtos(),Messages.DetailMessage);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_ıcar.GetAll(b => b.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_ıcar.GetAll(c => c.ColorId == colorId),Messages.ColorMessage);
        }

        public IResult Update(Car car)
        {
            _ıcar.Update(car);
            
            return new SuccessResult(Messages.UptatedMessage);
        }
    }
}

   

