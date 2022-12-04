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
    public class EmployeeTaskManager : IEmployeeTaskService
    {
        IEmployeeTaskDal _employeeTaskDal;

        public EmployeeTaskManager(IEmployeeTaskDal employeeTaskDal)
        {
            _employeeTaskDal = employeeTaskDal;
        }

        public List<EmployeeTask> GetEmployeeTasksByEmployee()
        {
            throw new NotImplementedException();
            
        }

        public void TDelete(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public EmployeeTask TGetById(int id)
        {
            throw new NotImplementedException();
        }
        public List<EmployeeTask> TGetEmployeeTasksByEmployee()
        {
            return _employeeTaskDal.GetEmployeeTasksByEmployee();
        }

        public List<EmployeeTask> TGetList()
        {
            return _employeeTaskDal.GetList();
        }

        public void TInsert(EmployeeTask t)
        {
            _employeeTaskDal.Insert(t);
        }

        public void TUpdate(EmployeeTask t)
        {
            throw new NotImplementedException();
        }
    }
}
