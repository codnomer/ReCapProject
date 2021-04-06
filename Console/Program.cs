using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            


            EfCarDal efCarDal = new EfCarDal();
            CarManager carManager = new CarManager(efCarDal);

            EfBrandDal efBrandDal = new EfBrandDal();
            BrandManager brandManager = new BrandManager(efBrandDal);

            EfRentalDal efRentalDal = new EfRentalDal();
            RentalManager rentalManager = new RentalManager(efRentalDal);

            EfUserDal efUserDal = new EfUserDal();
            UserManager userManager = new UserManager(efUserDal);

            EfCustomerDal efCustomerDal = new EfCustomerDal();
            CustomerManager customerManager = new CustomerManager(efCustomerDal);

            Users user = new Users { FirstName = "Ömer", LastName = "Demirhan", Email = "demrh@gmail.com", Password = "******", UserId = 4 };
            Customers customer = new Customers { CompanyName = "Ömer Demirhan", UserId = 4, CostumerId = 12 };




        }

        private static void TestingDtos()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDtos().Data)
            {
                Console.WriteLine(car.DailyPrice + "/" + car.BrandName + "/" + car.CarName + "/" + car.ColorName);
            }
        }

        //private static void AddingTest()
        //{
        //    Car testCar = new Car { BrandId = 2, ColorId = 1, DailyPrice = 50, Description = "Tofas", CarId = 5, ModelYear = 2014 };
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarsByColorId(1);

        //    carManager.Add(testCar);

        //    foreach (var car in result)
        //    {
        //        Console.WriteLine(car.DailyPrice);
        //    }
        //}
    }

   
}

