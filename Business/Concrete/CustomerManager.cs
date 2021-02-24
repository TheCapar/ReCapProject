using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            return new Result(true,Messages.CustomerEklendi);
        }

        public IResult Delete(Customer customer)
        {
            return new Result(true, "Müşteri Silindi");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new DataResult<List<Customer>>(_customerDal.GetAll(), true,"Müşteriler Sıralandı");
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new DataResult<Customer>(_customerDal.Get(c => c.CustomerId == customerId), true, "İstediğiniz Müşteri Bilgileri Geldi");
        }

        public IResult Update(Customer customer)
        {
            return new Result(true,"Müşteri Bilgileri Başarıyla Yenilendi");
        }
    }
}
