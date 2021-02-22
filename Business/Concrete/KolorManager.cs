using Business.Abstract;
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

        public Kolor GetById(int kolorId)
        {
            return _iKolorDal.Get(k=>k.KolorId==kolorId);
        }

        public List<Kolor> GetCarsByKolorId(int kolorId)
        {
            return _iKolorDal.GetAll(k => k.KolorId == kolorId);
        }

        public IResult Update(Kolor kolor)
        {
            _iKolorDal.Update(kolor);
            return new SuccessResult("Başarıyla Güncellendi");
        }
    }
}
