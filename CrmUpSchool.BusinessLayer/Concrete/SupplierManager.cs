using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.Concrete
{
    public class SupplierManager : ISupplierService
    {
       ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public void TDelete(Supplier t)
        {
            _supplierDal.Delete(t);
        }

        public Supplier TGetById(int id)
        {
            return _supplierDal.GetById(id);
        }

        public List<Supplier> TGetList()
        {
            return _supplierDal.GetList();
        }

        public void TInsert(Supplier t)
        {
            _supplierDal.Insert(t);
        }

        public void TUpdate(Supplier t)
        {
            _supplierDal.Update(t);
        }
    }
}
