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

            Car testCar = new Car { BrandId = 2, ColorId = 1, DailyPrice = 50.0f, Description = "Tofas", Id = 1, ModelYear = 2014 };
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

