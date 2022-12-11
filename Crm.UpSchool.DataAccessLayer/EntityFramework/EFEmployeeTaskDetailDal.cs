using Crm.UpSchool.DataAccessLayer.Concrete;
using Crm.UpSchool.DataAccessLayer.Repository;
using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.DataAccessLayer.EntityFramework
{
    public class EFEmployeeTaskDetailDal : GenericRepository<EmployeeTaskDetail>, IEmployeeTaskDetailDal
    {
        public List<EmployeeTaskDetail> GetEmployeeTaskDetailsById(int id)
        {
            using(var context = new Context())
            {
                return context.EmployeeTaskDetails.Where(x => x.EmployeeTaskID == id).ToList();
            }
        }
    }
}
