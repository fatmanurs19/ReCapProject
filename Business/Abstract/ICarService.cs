using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService 
    {
        //iş katmanında kullanacağımız servis operasyonları
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int id);
        IDataResult<List<Car>> GetByBrandId(int id);
        IDataResult<List<Car>> GetByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Delete(Car car);   
        IResult Update(Car car);   
        IResult Add(Car car);  
        
    }
}
