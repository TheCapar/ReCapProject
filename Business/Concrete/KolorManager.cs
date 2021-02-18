using Business.Abstract;
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

        public void Add(Kolor kolor)
        {
            _iKolorDal.Add(kolor);
        }

        public void Delete(Kolor kolor)
        {
            _iKolorDal.Delete(kolor);
        }

        public Kolor GetById(int kolorId)
        {
            return _iKolorDal.Get(k=>k.KolorId==kolorId);
        }

        public List<Kolor> GetCarsByKolorId(int kolorId)
        {
            return _iKolorDal.GetAll(k => k.KolorId == kolorId);
        }

        public void Update(Kolor kolor)
        {
            _iKolorDal.Update(kolor);
        }
    }
}
