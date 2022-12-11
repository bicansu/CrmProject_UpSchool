using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.EntityLayer.Concrete
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverEmail { get; set; }
        public string SerderName { get; set; }
        public string SenderEmail { get; set; }
        public DateTime Date { get; set; }
    }
}
