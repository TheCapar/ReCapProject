using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int CarId);
        void Add(Car car);
        void Delete(Car car);
        void Upgrade(Car car);
        List<CarDetailDto> GetCarDetails();


    }
}
