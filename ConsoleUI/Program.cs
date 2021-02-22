using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName+ "/" + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}
