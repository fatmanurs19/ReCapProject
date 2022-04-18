using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(car.Description.Length>=2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                if (car.Description.Length < 2)
                {
                    Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
                }
                else
                {
                    Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır.");
                }
            }
        }
        

        public List<Car> GetAll() //listeleme
        {
           
            //bir iş sınıfı başka bir sınıfı newlemez
            //INJECTION
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int id) //brand idye göre
        {
            return _carDal.GetAll(c=>c.BrandId==id);
        }

        
        public List<Car> GetByColorId(int id) //color ıdye göre
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
        public void Delete(Car car) //silme
        {
            _carDal.Delete(car);
        }
        public void Update(Car car) //güncelleme
        {
            _carDal.Update(car);
        }

        public List<Car> GetById(int id) //idye göre
        {
            return _carDal.GetAll(c => c.CarId == id);
        }
    }
}
