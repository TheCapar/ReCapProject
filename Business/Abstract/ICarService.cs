using Core.Utilities.Results;
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
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Upgrade(Car car);
        List<CarDetailDto> GetCarDetails();


    }
}
