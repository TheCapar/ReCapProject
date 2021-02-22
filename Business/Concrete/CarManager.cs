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
                return new ErrorResult(Messages.ArabaEklenmedi);
            }
            return new SuccessResult(Messages.ArabaEklendi);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Başarıyla Silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new DataResult<List<Car>>(_carDal.GetAll(),true,"Başarıyla Listelendi");
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new DataResult<Car>(_carDal.Get(c => c.CarId == carId),true,"Başarıyla Listelendi");
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new DataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),true,"Başarıyla Listelendi");
        }

        public IResult Upgrade(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Başarıyla Güncellendi");
        }
    }
}
