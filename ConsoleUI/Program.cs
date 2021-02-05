using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Descriptions);
            }
            carManager.Add(new Brand { BrandName = "Porsche" }, new Car { DailyPrice = 1000000 });
            carManager.Add(new Brand { BrandName = "a" }, new Car { DailyPrice = -1 });

        }
    }
}
