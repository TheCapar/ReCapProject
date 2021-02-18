using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager :ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;       
        }

        public void Add(Car car)
        {
            if(car.DailyPrice>=0 && car.Description.Length>=2) {
                _carDal.Add(car); 
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int CarId)
        {
            return _carDal.GetById(c => c.CarId == CarId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.
        }

        public void Upgrade(Car car)
        {
            _carDal.Update(car);
        }
    }
}
