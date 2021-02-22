﻿using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Brand brand)
        {
            _iBrandDal.Add(brand);
            return new SuccessResult("Başarıyla Eklendi");
        }

        public IResult Delete(Brand brand)
        {
            _iBrandDal.Delete(brand);
            return new SuccessResult("Başarıyla Silindi");
        }

        public Brand GetById(int brandId)
        {
            return _iBrandDal.Get(b => b.BrandId == brandId);
        }

        public List<Brand> GetCarsByBrandId(int brandId)
        {
            return _iBrandDal.GetAll(b => b.BrandId == brandId);
        }

        public IResult Update(Brand brand)
        {
            _iBrandDal.Update(brand);
            return new SuccessResult("Başarıyla Güncellendi");        
        }
    }
}
