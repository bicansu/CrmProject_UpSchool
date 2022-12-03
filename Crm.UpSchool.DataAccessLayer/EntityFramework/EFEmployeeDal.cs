using Crm.UpSchool.DataAccessLayer.Abstract;
using Crm.UpSchool.DataAccessLayer.Concrete;
using Crm.UpSchool.DataAccessLayer.Repository;
using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.UpSchool.DataAccessLayer.EntityFramework
{
    public class EFEmployeeDal : GenericRepository<Employee>, IEmployeeDal
    {
        public void ChangeEmployeeStatusToFalse(int id)
        {
            using(var context = new Context())
            {
                var values = context.Employees.Find(id);
                values.EmployeeStatus = false;
                context.SaveChanges();
            }
        }

        public void ChangeEmployeeStatusToTrue(int id)
        {
            using(var context = new Context())
            {
                var values = context.Employees.Find(id);
                values.EmployeeStatus = true;
                context.SaveChanges();
            }
        }

        public List<Employee> GetEmployeesByCategory()
        {
            using(var context = new Context())
            {
                return context.Employees.Include(x=>x.Category).ToList();
            }
        }
    }
}
