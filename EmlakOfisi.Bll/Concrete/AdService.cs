using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmlakOfisi.Bll.Concrete
{
	public class AdService : IAdService
	{
		private IAdDal _adDal;
		public AdService(IAdDal adDal)
		{
			_adDal = adDal;
		}
		public void Add(AdEntity entity)
		{
			_adDal.Add(entity);
		}

		public void Delete(AdEntity entitiy)
		{
			_adDal.Delete(entitiy);
		}

		public AdEntity Find(Expression<Func<AdEntity, bool>> expression)
		{
			return _adDal.Find(expression);
		}

		public List<AdEntity> GetAll()
		{
			return _adDal.GetAll();
		}

		public List<AdEntity> GetAllByFilter(Expression<Func<AdEntity, bool>> expression)
		{
			return _adDal.GetAllByFilter(expression);
		}

		public AdEntity GetById(int id)
		{
			return _adDal.GetById(id);
		}

		public void Update(AdEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
