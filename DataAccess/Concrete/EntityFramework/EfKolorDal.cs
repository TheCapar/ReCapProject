using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKolorDal : IKolorDal
    {
        public void Add(Kolor entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Kolor entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Kolor Get(Expression<Func<Kolor, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Kolor>().SingleOrDefault(filter);
            }
        }

        public List<Kolor> GetAll(Expression<Func<Kolor, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null
                    ? context.Set<Kolor>().ToList()
                    : context.Set<Kolor>().Where(filter).ToList();
            }
        }

        public void Uprade(Kolor entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var upradeEntity = context.Entry(entity);
                upradeEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
