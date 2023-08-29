using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class CategoryManager:ICategoryService
	{
        ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
            _categoryDal = categoryDal;
		}

        public Category GetById(int id)
        {
           return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetList();
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TInsert(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}

