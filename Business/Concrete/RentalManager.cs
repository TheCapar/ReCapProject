using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentaldal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentaldal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnTime != null) { 
                return new SuccessResult("Araba Kiralanabilir"); 
            }
            else
            {
                return new ErrorResult("Arabayı Kiralanmıyor Çünkü Teslim Edilmemiş");
            }
        }

        public IResult Delete(Rental rental)
        {
            return new Result(true, Messages.RentalEklendi);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new DataResult<List<Rental>>(_rentaldal.GetAll(),true,"Başarıyla Kiralananlar Listelendi");
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new DataResult<Rental>(_rentaldal.Get(r=>r.RentalId == rentalId),true,"Seçilen Kirlama Gösteriliyor");
        }

        public IResult Update(Rental rental)
        {
            return new Result(true, Messages.RentalEklendi); 
        }
    }
}
