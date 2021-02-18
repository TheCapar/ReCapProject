using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join k in context.Kolors
                             on c.KolorId equals k.KolorId
                             join b in context.Brands on
                             c.BrandId equals b.BrandId
                             select new CarDetailDto 
                             { 
                                          CarName = c.CarName,
                                          BrandName = b.BrandName,
                                          KolorName = k.KolorName,
                                          DailyPrice = c.DailyPrice    
                             };


                return result.ToList();
            }

        }
    }
}
