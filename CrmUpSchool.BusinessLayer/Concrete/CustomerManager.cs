using Crm.UpSchool.DataAccessLayer.Abstract;
using Crm.UpSchool.DataAccessLayer.EntityFramework;
using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.Contrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
             _customerDal = customerDal;
        }
        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public Customer TGetById(int id)
        {
           return _customerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
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
