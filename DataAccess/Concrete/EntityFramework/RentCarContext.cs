using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
    public class RentCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RentCar;Trusted_Connection=True");
        }

        public DbSet<Car> CarTable { get; set; }
        public DbSet<Brand> BrandTable { get; set; }
        public DbSet<Color> ColorTable { get; set; }
        public DbSet<Customers> CustomerTable { get; set; }

        public DbSet<Users> UserTable  { get; set; }
        public DbSet<Rental> RentalTable { get; set; }






    }
}
