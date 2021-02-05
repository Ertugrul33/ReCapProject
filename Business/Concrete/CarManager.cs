using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Add(Brand brand, Car car)
        {
            if (brand.BrandName.Length > 2 && car.DailyPrice > 0)
            {
                Console.WriteLine("Marka başarıyla eklendi: " + brand.BrandName);
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
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
    }
}
