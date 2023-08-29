using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IProductService : IGenericService<Product>
	{
        List<Product> GetProductListWithCategory();
    }
}

