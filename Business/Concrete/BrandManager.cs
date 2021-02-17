using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _iBrandDal;
        public BrandManager(IBrandDal ibrandDal)
        {
            _iBrandDal = ibrandDal;
        }
        public List<Brand> GetCarsByBrandId(int brandId)
        {
            return _iBrandDal.GetAll(b => b.BrandId == brandId);
        }
    }
}
