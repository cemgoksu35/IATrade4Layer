using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class CustomerManager:ICustomerService
	{
        ICustomerDal _customerDal;
		public CustomerManager(ICustomerDal customerDal)
		{
            _customerDal = customerDal;
		}

        public Customer GetById(int id)
        {
          return _customerDal.GetById(id);
        }

        public List<Customer> GetList()
        {
            return _customerDal.GetList();
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}

