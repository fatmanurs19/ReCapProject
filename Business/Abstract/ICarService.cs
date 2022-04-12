using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        //iş katmaında kullanacağımız servis operasyonları
        List<Car> GetAll();

    }
}
