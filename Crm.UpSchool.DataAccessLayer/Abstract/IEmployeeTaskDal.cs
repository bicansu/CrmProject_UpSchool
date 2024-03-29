﻿using Crm.UpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.DataAccessLayer.Abstract
{
    public interface IEmployeeTaskDal:IGenericDal<EmployeeTask>
    {
        List<EmployeeTask> GetEmployeeTasksByEmployee();
        List<EmployeeTask> GetEmployeeTasksById(int id);
    }
}
