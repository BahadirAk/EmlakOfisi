using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmlakOfisi.Dal.Concrete
{
	public class EfAdDal : IAdDal
	{
		private EmlakOfisiContext _context;
		public EfAdDal(EmlakOfisiContext context)
		{
			_context = context;
		}
		public void Add(AdEntity entity)
		{
			_context.Ads.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(AdEntity entitiy)
		{
			var ad = _context.Ads.FirstOrDefault(x => x.Id == entitiy.Id);
			ad.IsDeleted = true;
			_context.SaveChanges();
		}

		public AdEntity Find(Expression<Func<AdEntity, bool>> expression)
		{
			return _context.Ads.FirstOrDefault(expression);
		}

		public List<AdEntity> GetAll()
		{
			return _context.Ads.ToList();
		}

		public List<AdEntity> GetAllByFilter(Expression<Func<AdEntity, bool>> expression)
		{
			return _context.Ads.Where(x => x.IsDeleted == false).Where(expression).ToList();
		}

		public AdEntity GetById(int id)
		{
			return _context.Ads.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
		}

		public void Update(AdEntity entity)
		{
			_context.Update(entity);
			_context.SaveChanges();
		}
	}
}
