using Crm.UpSchool.DataAccessLayer.Concrete;
using Crm.UpSchool.DataAccessLayer.Repository;
using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CrmUpSchool.DataAccessLayer.EntityFramework
{
    public class EFEmployeeTaskDal : GenericRepository<EmployeeTask>, IEmployeeTaskDal
    {
        public List<EmployeeTask> GetEmployeeTasksByEmployee()
        {
            using (var context = new Context())
          {
              var values = context.EmployeeTasks.Include(x => x.AppUser).ToList();
              return values;
          }
        }
    }
}
