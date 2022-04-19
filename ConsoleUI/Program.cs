using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarTest();

//static void CarTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    foreach (var car in carManager.GetByColorId(1))
//    {
//        Console.WriteLine(car.CarName);
//    }
//}

//BrandTest();

//static void BrandTest()
//{
//    BrandManager brandManager = new BrandManager(new EfBrandDal());
//    foreach (var brand in brandManager.GetAll())
//    {
//        Console.WriteLine(brand.BrandName);
//    }
//}

//ColorTest();

//static void ColorTest()
//{
//    ColorManager colorManager = new ColorManager(new EfColorDal());
//    foreach (var color in colorManager.GetAll())
//    {
//        Console.WriteLine(color.ColorName);
//    }
//}

//CarAddTest();

//static void CarAddTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    carManager.Add(new Car
//    {
//        CarId = 11,
//        CarName = "HYUNDAI",
//        BrandId = 11,
//        ColorId = 4,
//        ModelYear = "2016",
//        DailyPrice = 700,
//        Description = "3 days"
//    });
//    foreach (var car in carManager.GetAll())
//    {
//        Console.WriteLine(car.CarName);
//    }
//}

//CarDeleteTest();

//static void CarDeleteTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    carManager.Delete(new Car { CarId = 11 });
//    foreach (var car in carManager.GetAll())
//    {
//        Console.WriteLine(car.CarName);
//    }
//}


//CarUpdateTest();

//static void CarUpdateTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    carManager.Update(new Car { CarId = 10, CarName = "TESLA", BrandId = 10, ColorId = 5, ModelYear = "2018", DailyPrice = 1000, Description = "5 DAYS" });
//    foreach (var car in carManager.GetAll())
//    {
//        Console.WriteLine(car.CarName);
//    }
//}

//CarGetByIdTest();

//static void CarGetByIdTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    foreach (var car in carManager.GetById(10))
//    {
//        Console.WriteLine(car.CarName);
//    }
//}


//BrandAddTest();

//static void BrandAddTest()
//{
//    BrandManager brandManager = new BrandManager(new EfBrandDal());
//    brandManager.Add(new Brand { BrandId = 11, BrandName = "HYUNDAI" });
//    foreach (var brand in brandManager.GetAll())
//    {
//        Console.WriteLine(brand.BrandName);
//    }
//}

//BrandDeleteTest();

//static void BrandDeleteTest()
//{
//    BrandManager brandManager = new BrandManager(new EfBrandDal());
//    brandManager.Delete(new Brand { BrandId = 11 });
//    foreach (var brand in brandManager.GetAll())
//    {
//        Console.WriteLine(brand.BrandName);
//    }
//}

//BrandUpdateTest();

//static void BrandUpdateTest()
//{
//    BrandManager brandManager = new BrandManager(new EfBrandDal());
//    brandManager.Update(new Brand { BrandId = 10, BrandName = "TESLA" });
//    foreach (var brand in brandManager.GetAll())
//    {
//        Console.WriteLine(brand.BrandName);
//    }
//}

//ColorAddTest();

//static void ColorAddTest()
//{
//    ColorManager colorManager = new ColorManager(new EfColorDal());
//    colorManager.Add(new Color { ColorId = 7, ColorName = "Dark Blue" });
//    foreach (var color in colorManager.GetAll())
//    {
//        Console.WriteLine(color.ColorName);
//    }
//}


//ColorDeleteTest();

//static void ColorDeleteTest()
//{
//    ColorManager colorManager = new ColorManager(new EfColorDal());
//    colorManager.Delete(new Color { ColorId = 7 });
//    foreach (var color in colorManager.GetAll())
//    {
//        Console.WriteLine(color.ColorName);
//    }
//}


//ColorUpdateTest();

//static void ColorUpdateTest()
//{
//    ColorManager colorManager = new ColorManager(new EfColorDal());
//    colorManager.Update(new Color { ColorId = 5, ColorName = "Dark Blue" });
//    foreach (var color in colorManager.GetAll())
//    {
//        Console.WriteLine(color.ColorName);
//    }
//}

CarManager carManager = new CarManager(new EfCarDal());
var result = carManager.GetCarDetails();

if (result.Success==true)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.CarName + "/" + car.BrandName);
    }
}
else
{
    Console.WriteLine(result.Message);
}

	