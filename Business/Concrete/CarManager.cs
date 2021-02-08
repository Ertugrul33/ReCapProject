using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                Console.WriteLine("Araba başarıyla eklendi: " + car.CarName);
                Console.WriteLine("Günlük Fiyatı: " + car.DailyPrice);

            }
            else
            {
                Console.WriteLine("Araba ismi minimum 2 karakter ve günlük fiyatı 0'dan büyük olmalıdır.");
            }
        }

        public List<Car> GetAll()
        {
            //İş Kodları
            //...
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(ca => ca.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(ca => ca.ColorId == id);
        }
        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            Console.WriteLine("Araba başarıyla güncellendi: " + car.CarName);
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Marka başarıyla silindi: " + car.CarName);
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(ca => ca.CarId == carId);
        }
    }
}
