using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmlakOfisi.Dal.Concrete
{
	public class EfUserDal : IUserDal
	{
		private EmlakOfisiContext _context;
		public EfUserDal(EmlakOfisiContext context)
		{
			_context = context;
		}
		public void Add(UserEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(UserEntity entitiy)
		{
			throw new NotImplementedException();
		}

		public UserEntity Find(Expression<Func<UserEntity, bool>> expression)
		{
			return _context.Users.FirstOrDefault(expression);
		}

		public List<UserEntity> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<UserEntity> GetAllByFilter(Expression<Func<UserEntity, bool>> expression)
		{
			throw new NotImplementedException();
		}

		public UserEntity GetById(int id)
		{
			return _context.Users.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
		}

		public void Update(UserEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
