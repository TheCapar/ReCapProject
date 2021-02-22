using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if(car.DailyPrice>=0 && car.Description.Length>=2) {
                _carDal.Add(car);
                return new ErrorResult(Messages.UrunEklenmedi);
            }
            return new SuccessResult(Messages.UrunEklendi);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Başarıyla Silindi");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int CarId)
        {
            return _carDal.Get(c => c.CarId == CarId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public IResult Upgrade(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Başarıyla Güncellendi");
        }
    }
}
