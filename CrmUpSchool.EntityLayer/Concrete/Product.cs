using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int ProductStock { get; set; }
    }
}
