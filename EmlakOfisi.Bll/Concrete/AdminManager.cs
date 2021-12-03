using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmlakOfisi.Bll.Concrete
{
	public class AdminManager : IAdminManager
	{
		private IAdminDal _adminDal;
		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
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
			return _adminDal.GetById(id);
		}

		public void Update(AdminEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
