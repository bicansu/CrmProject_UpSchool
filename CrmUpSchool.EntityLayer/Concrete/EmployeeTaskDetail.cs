using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.EntityLayer.Concrete
{
    public class EmployeeTaskDetail
    {
        public int EmployeeTaskDetailID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeTaskID { get; set; }
        public EmployeeTask EmployeeTask { get; set; }
        

    }
}
