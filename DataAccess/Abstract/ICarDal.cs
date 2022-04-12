﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    //iş yapan classları oluşturacağımız zaman ilk mutlaka interface oluşturmalıyız.
    //productla ilgili veri tabanında yapacağım operasyonların interface i
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetById(int carId);

    }
}