using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brand;

        public BrandManager(IBrandDal brand)
        {
            _brand = brand;
        }

        public List<Brand> GetAll()
        {
            return _brand.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brand.GetById(b => b.BrandId == brandId);
        }
    }
}
