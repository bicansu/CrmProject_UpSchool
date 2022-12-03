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
    public class EFCustomeryDal : GenericRepository<Customer>,ICustomerDal
    { 

    }
}
