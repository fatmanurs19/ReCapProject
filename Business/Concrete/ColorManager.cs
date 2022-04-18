using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal) //constructor injection yaptık.
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
           _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll() //renkleri listeleme
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId) //renkleri renk idsine göre getirme
        {
           return _colorDal.Get(c=>c.ColorId==colorId);
        }

        public void Update(Color color)
        {
           _colorDal.Update(color);
        }
    }
}
