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
    public class MessageManager : IMessageService
    {
        IMessageDal _mesageDal;

        public MessageManager(IMessageDal mesageDal)
        {
            _mesageDal = mesageDal;
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Message t)
        {
            _mesageDal.Insert(t);
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
