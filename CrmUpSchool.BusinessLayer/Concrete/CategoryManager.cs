using Crm.UpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.Contrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        //Bağımlılıkları minimilize etmek için kullanıyoruz.
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TInsert(Category t)
        {
            //if(t.CategoryName!= null & t.CategoryName.Length>=5 & t.CategoryDescription.StartsWith("A"))
            // {
            //     _categoryDal.Insert(t);
            // }
            // else
            // {
            //     // hata mesajı
            // }

            _categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
