using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmlakOfisi.Dal.Abstract
{
	public interface IBaseDal<T>
	{
		List<T> GetAll();

		List<T> GetAllByFilter(Expression<Func<T, bool>> expression);
		T GetById(int id);
		T Find(Expression<Func<T, bool>> expression);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entitiy);
	}
}
