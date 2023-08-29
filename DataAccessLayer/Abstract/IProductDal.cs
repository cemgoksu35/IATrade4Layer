using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IProductDal : IGenericDal<Product>
	{
		List<Product> GetListWithCategory();
	}
}

