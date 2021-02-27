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
    public class KolorManager : IKolorService
    {
        IKolorDal _iKolorDal;
        public KolorManager(IKolorDal ikolorDal)
        {
            _iKolorDal = ikolorDal;
        }

        public IResult Add(Kolor kolor)
        {
            _iKolorDal.Add(kolor);
            return new SuccessResult("Başarıyla Eklendi");
        }

        public IResult Delete(Kolor kolor)
        {
            _iKolorDal.Delete(kolor);
            return new SuccessResult("Başarıyla Silindi");
        }
        public IResult Update(Kolor kolor)
        {
            _iKolorDal.Update(kolor);
            return new SuccessResult("Başarıyla Güncellendi");
        }
        public IDataResult<Kolor> GetById(int colorId)
        {
            return new SuccessDataResult<Kolor>(_iKolorDal.Get(c => c.KolorId == colorId));
        }
        public IDataResult<List<Kolor>> GetAll()
        {
            return new SuccessDataResult<List<Kolor>>(_iKolorDal.GetAll(), Messages.ColorGetAll);
        }
    }
}
