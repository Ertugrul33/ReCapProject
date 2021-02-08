using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            Console.WriteLine("Renk başarıyla eklendi: " + color.ColorName);
        }

        public void Delete(Color color)
        {
            Console.WriteLine("Renk başarıyla silindi: " + color.ColorName);
        }

        public List<Color> GetAll()
        {
            //İş kodları
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(co => co.ColorId == colorId);
        }

        public void Update(Color color)
        {
            Console.WriteLine("Renk başarıyla güncellendi: " + color.ColorName);
        }
    }
}
