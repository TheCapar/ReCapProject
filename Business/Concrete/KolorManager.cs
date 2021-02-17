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
        public List<Kolor> GetCarsByKolorId(int kolorId)
        {
            return _iKolorDal.GetAll(k => k.KolorId == kolorId);
        }
    }
}
