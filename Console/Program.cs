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
            //AddingTest();
            TestingDtos();
            
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 8, CarId = 10, CarName = "Vosvos", ColorId = 10, DailyPrice = 100, Description = "Temiz bir araba", ModelYear = 2002 });
            carManager.Add(new Car { BrandId = 7, CarId = 12, CarName = "BMW", ColorId = 8, DailyPrice = 130, Description = "Temiz bir araba", ModelYear = 2020 });
            carManager.Add(new Car { BrandId = 9, CarId = 11, CarName = "Passat", ColorId = 9, DailyPrice = 230, Description = "Temiz bir araba", ModelYear = 2012 });
            carManager.Add(new Car { BrandId = 10, CarId = 13, CarName = "Ferrari", ColorId = 11, DailyPrice = 330, Description = "Temiz bir araba", ModelYear = 2019 });






        }

        private static void TestingDtos()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.DailyPrice + "/" + car.BrandName + "/" + car.CarName + "/" + car.ColorName);
            }
        }

        private static void AddingTest()
        {
            Car testCar = new Car { BrandId = 2, ColorId = 1, DailyPrice = 50, Description = "Tofas", CarId = 5, ModelYear = 2014 };
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByColorId(1);

            carManager.Add(testCar);

            foreach (var car in result)
            {
                Console.WriteLine(car.DailyPrice);
            }
        }
    }

   
}

