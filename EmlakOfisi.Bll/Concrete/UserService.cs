using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmlakOfisi.Bll.Concrete
{
	public class UserService : IUserService
	{
		private IUserDal _userDal;
		public UserService(IUserDal userDal)
		{
			_userDal = userDal;
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
			return _userDal.Find(expression);
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
			return _userDal.GetById(id);
		}

		public void Update(UserEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
