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
            CarTest();
            BrandTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
            Console.WriteLine("-----------------");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} --- {1}", car.CarName, car.BrandName);
            }
            Console.WriteLine("-----------------");
            carManager.Add(new Car { CarName = "Porsche Carrera GT", DailyPrice = 1000000 });
            Console.WriteLine("-----------------");
            carManager.Add(new Car { CarName = "a", DailyPrice = -1 });
            Console.WriteLine("-----------------");
            carManager.Update(new Car { CarName = "MERCEDES AMG" });
            Console.WriteLine("-----------------");
            carManager.Delete(new Car { CarName = "BMW M5" });
            Console.WriteLine("-----------------");
            carManager.GetById(3);

        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var car in brandManager.GetAll())
            {
                Console.WriteLine(car.BrandName);
            }
            Console.WriteLine("-----------------");
            brandManager.Add(new Brand { BrandName = "Porsche"});
            Console.WriteLine("-----------------");
            brandManager.Update(new Brand { BrandName = "MERCEDES" });
            Console.WriteLine("-----------------");
            brandManager.Delete(new Brand { BrandName = "BMW" });
            Console.WriteLine("-----------------");
            brandManager.GetById(2);

        }
    }
}
