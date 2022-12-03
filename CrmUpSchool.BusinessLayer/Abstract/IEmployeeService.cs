using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.Abstract
{
    public interface IEmployeeService : IGenericService<Employee>
    {
        List<Employee> TGetEmployeesByCategory();
        void TChangeEmployeeStatusToTrue(int id);
        void TChangeEmployeeStatusToFalse(int id);
    }
}
