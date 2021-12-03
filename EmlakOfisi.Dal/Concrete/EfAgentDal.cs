using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmlakOfisi.Dal.Concrete
{
	public class EfAgentDal : IAgentDal
	{
		private EmlakOfisiContext _context;
		public EfAgentDal(EmlakOfisiContext context)
		{
			_context = context;
		}
		public void Add(AgentEntity entity)
		{
			_context.Agents.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(AgentEntity entity)
		{
			var agent = _context.Agents.FirstOrDefault(x => x.Id == entity.Id);
			agent.IsDeleted = true;
			_context.SaveChanges();
		}

		public AgentEntity Find(Expression<Func<AgentEntity, bool>> expression)
		{
			return _context.Agents.FirstOrDefault(expression);
		}

		public List<AgentEntity> GetAll()
		{
			return _context.Agents.ToList();
		}

		public List<AgentEntity> GetAllByFilter(Expression<Func<AgentEntity, bool>> expression)
		{
			return _context.Agents.Where(x => x.IsDeleted == false).Where(expression).ToList();
		}

		public AgentEntity GetById(int id)
		{
			return _context.Agents.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
		}

		public void Update(AgentEntity entity)
		{
			_context.Update(entity);
			_context.SaveChanges();
		}
	}
}
