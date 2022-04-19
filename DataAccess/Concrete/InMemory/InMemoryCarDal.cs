using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;  //global değişken
        public InMemoryCarDal() //constructor bellekte referans aldığı zaman çalışacak olan blok
        {
            _cars = new List<Car>() {
            new Car() { CarId = 1,BrandId=1,ColorId=2,ModelYear="2012",DailyPrice=1400 ,Description="Mercedes"},
            new Car() { CarId = 2,BrandId=2,ColorId=3,ModelYear="2015",DailyPrice=1000 ,Description="AUDI"},
            new Car() { CarId = 3,BrandId=3,ColorId=1,ModelYear="2017",DailyPrice=1200 ,Description="BMW"},
            new Car() { CarId = 4,BrandId=4,ColorId=4,ModelYear="2013",DailyPrice=2000 ,Description="BUGATTI"},
            new Car() { CarId = 4,BrandId=5,ColorId=5,ModelYear="2018",DailyPrice=1800 ,Description="PORCHE"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get()
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
           return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            
        }
    }
}
