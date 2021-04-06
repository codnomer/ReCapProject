using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;
using Entities.DTOs;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customers, RentCarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> CustomerDetailDto()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from c in context.CustomerTable
                             join u in context.UserTable
                             on c.CostumerId equals u.UserId
                             select new CustomerDetailDto
                             {
                                 UserFirstName = u.FirstName,
                                 UserLastName = u.LastName,
                                 UserMail = u.Email,
                                 CompanyName = c.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
