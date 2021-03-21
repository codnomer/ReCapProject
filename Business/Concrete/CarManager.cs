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
            _ıcar.Add(car);
        }

        public void Delete(Car car)
        {
            _ıcar.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _ıcar.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _ıcar.GetById(id);
        }

        public void Update(Car car)
        {
            _ıcar.Update(car);
        }
    }
}
