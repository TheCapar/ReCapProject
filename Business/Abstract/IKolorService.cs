using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKolorService
    {
        void Add(Kolor kolor);
        void Delete(Kolor kolor);
        void Update(Kolor kolor);
        Kolor GetById(int kolorId);
        List<Kolor> GetCarsByKolorId(int kolorId);
    }
}
