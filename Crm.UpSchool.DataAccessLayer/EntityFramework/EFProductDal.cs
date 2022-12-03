using Crm.UpSchool.DataAccessLayer.Abstract;
using Crm.UpSchool.DataAccessLayer.Repository;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.UpSchool.DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public void Delete(Product t)
        {
            throw new NotImplementedException();
        }

        public void GetProductByCetgory()
        {
            throw new NotImplementedException();
        }

        public void Insert(Product t)
        {
            throw new NotImplementedException();
        }

        public void Update(Product t)
        {
            throw new NotImplementedException();
        }

        Product IGenericDal<Product>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Product> IGenericDal<Product>.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
