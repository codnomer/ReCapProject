using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Add(Car car)
        {
            if (car.Description.Length < 3)
            {
                Console.WriteLine("Araç açıklaması en az iki karakter olmalı");
            }
            else if (car.DailyPrice < 1)
            {
                Console.WriteLine("Fiyat 0 dan büyük olmalıdır");
            }
            else
            { _ıcar.Add(car); }


        }

        public void Delete(Car car)
        {
            _ıcar.Delete(car);
            
        }

        public List<Car> GetAll()
        {
            return _ıcar.GetAll();
        }

       

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _ıcar.GetAll(b => b.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _ıcar.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _ıcar.Update(car);
        }
    }
}

   

