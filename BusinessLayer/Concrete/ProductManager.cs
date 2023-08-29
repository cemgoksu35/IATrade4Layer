using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int id)
        {

            return _productDal.GetById(id);        }

        public List<Product> GetList()
        {
            return _productDal.GetList();
        }

        public List<Product> GetProductListWithCategory()
        {
            return _productDal.GetListWithCategory();
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
           
        }
        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}

