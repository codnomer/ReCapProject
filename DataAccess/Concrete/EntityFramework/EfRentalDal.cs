using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using Entities.DTOs;
using Entities.Concrete;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDto()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from ren in context.RentalTable
                             join car in context.CarTable
                             on ren.CarId equals car.CarId
                             join cus in context.CustomerTable
                             on ren.CustomerId equals cus.CostumerId
                             join user in context.UserTable
                             on cus.UserId equals user.UserId
                             join col in context.ColorTable
                             on car.ColorId equals col.ColorId
                             join bra in context.BrandTable
                             on car.BrandId equals bra.BrandId

                             select new RentalDetailDto
                             {

                                 CarDescription = car.Description,
                                 ColorName = col.ColorName,
                                 BrandName = bra.BrandName,
                                 CompanyName = cus.CompanyName,
                                 CustomerFirstName = user.FirstName,
                                 CustomerLastName = user.LastName,
                                 DailyPrice = car.DailyPrice,
                                 RentDate = ren.RentDate,
                                 ReturnDate = ren.ReturnDate,
                             };

                return result.ToList();
            }
        }
    }
}
