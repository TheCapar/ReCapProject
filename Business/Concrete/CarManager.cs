using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public void Add(Car car)
        {
            if(car.DailyPrice>=0 && car.Description.Length>=2) {
                _iCarDal.Add(car); 
            }
            
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }
    }
}
