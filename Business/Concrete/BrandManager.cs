using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            Console.WriteLine("Marka başarıyla eklendi: " + brand.BrandName);
        }

        public void Delete(Brand brand)
        {
            Console.WriteLine("Marka başarıyla silindi: " + brand.BrandName);
        }

        public List<Brand> GetAll()
        {
            //İş kodları
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            Console.WriteLine("Marka başarıyla güncellendi: " + brand.BrandName);
        }
    }
}
