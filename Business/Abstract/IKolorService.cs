using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKolorService
    {
        IResult Add(Kolor kolor);
        IResult Delete(Kolor kolor);
        IResult Update(Kolor kolor);
        IDataResult<List<Kolor>> GetAll();
        IDataResult<Kolor> GetById(int kolorId);
    }
}
