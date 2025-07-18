﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal:IGenericDal<Customer>
    {
        void Insert(Customer p);
        void Update(Customer p);
        void Delete(Customer p);
        List<Customer> GetList();
        List<Customer> GetCustomerListWithJob();
    }
}
