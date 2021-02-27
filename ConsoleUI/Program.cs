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
            //CarTest();
            //BrandTest();
            RentalTest();

            CarImage carImage = new CarImage
            {
                Id = 1,
                CarId = 1,
                ImagePath = @"c:\sources\images\birinci.ikinci.ucuncu.jpg",
                Date = DateTime.Now
            };
            string[] fileSplit = carImage.ImagePath.Split('.');
            var extensionOfFile = "." + fileSplit[fileSplit.Length - 1];
            var newPathName = Guid.NewGuid().ToString() + extensionOfFile;
            Console.WriteLine(newPathName);
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CustomerId = 1, CarId = 1, RentDate = DateTime.Now});
            rentalManager.Add(new Rental { CustomerId = 1, CarId = 1, RentDate = DateTime.Now});
            rentalManager.Add(new Rental { CustomerId = 2, CarId = 1, RentDate = DateTime.Now});

            foreach (var rental in rentalManager.GetRentalDetails(1).Data)
            {
                Console.WriteLine("Araba adı = " + rental.CarName + ",   Müşteri adı = " + rental.CustomerName +
                    ",  Arabayı kiraladığı gün = " + rental.RentDate + ",  Kullanıcı adı = " + rental.UserName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.GetAll();
            Console.WriteLine("-----------------");
            Console.WriteLine("(Araba Adı --- Marka Adı)");
            carManager.GetCarDetails();
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
            brandManager.GetAll();
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
