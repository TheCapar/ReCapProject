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

        public void Add(Brand brand)
        {
            _iBrandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _iBrandDal.Delete(brand);
        }

        public Brand GetById(int brandId)
        {
            return _iBrandDal.Get(b => b.BrandId == brandId);
        }

        public List<Brand> GetCarsByBrandId(int brandId)
        {
            return _iBrandDal.GetAll(b => b.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            _iBrandDal.Update(brand);
        }
    }
}
