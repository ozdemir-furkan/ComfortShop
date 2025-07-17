using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : IGenericService<Customer>
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }

        public List<Customer> GetCustomersListWithJob()
        {
            return _customerDal.GetCustomerListWithJob();
        }
    }
}
