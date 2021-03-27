using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from ca in context.CarTable
                             join b in context.BrandTable on ca.BrandId equals b.BrandId
                             join cl in context.ColorTable on ca.ColorId equals cl.ColorId
                             select new CarDetailDto 
                             {   BrandName  = b.BrandName,
                                 CarName    = ca.CarName,
                                 ColorName  = cl.ColorName,
                                 DailyPrice = ca.DailyPrice
                             };
                return result.ToList();


            }
        }
    }
}
