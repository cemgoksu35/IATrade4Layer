﻿using System;
namespace BusinessLayer.Abstract
{
	public interface IGenericService<T>
	{
		void TInsert(T t);
		void TDelete(T t);
		void TUpdate(T t);
		List<T> GetList();
		T GetById(int id);
	}
}

