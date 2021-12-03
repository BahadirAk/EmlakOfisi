using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmlakOfisi.Dal.Concrete
{
	public class EfAdminDal : IAdminDal
	{
		private EmlakOfisiContext _context;
		public EfAdminDal(EmlakOfisiContext context)
		{
			_context = context;
		}
		public void Add(AdminEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(AdminEntity entity)
		{
			throw new NotImplementedException();
		}

		public AdminEntity Find(Expression<Func<AdminEntity, bool>> expression)
		{
			throw new NotImplementedException();
		}

		public List<AdminEntity> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<AdminEntity> GetAllByFilter(Expression<Func<AdminEntity, bool>> expression)
		{
			throw new NotImplementedException();
		}

		public AdminEntity GetById(int id)
		{
			return _context.Admins.Find(id);
		}

		public void Update(AdminEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
