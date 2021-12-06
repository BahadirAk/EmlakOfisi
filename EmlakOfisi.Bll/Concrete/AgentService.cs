using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmlakOfisi.Bll.Concrete
{
	public class AgentService : IAgentService
	{
		private IAgentDal _agentDal;
		public AgentService(IAgentDal agentDal)
		{
			_agentDal = agentDal;
		}
		public void Add(AgentEntity entity)
		{
			_agentDal.Add(entity);
		}

		public void Delete(AgentEntity entitiy)
		{
			_agentDal.Delete(entitiy);
		}

		public AgentEntity Find(Expression<Func<AgentEntity, bool>> expression)
		{
			return _agentDal.Find(expression);
		}

		public List<AgentEntity> GetAll()
		{
			return _agentDal.GetAll();
		}

		public List<AgentEntity> GetAllByFilter(Expression<Func<AgentEntity, bool>> expression)
		{
			return _agentDal.GetAllByFilter(expression);
		}

		public AgentEntity GetById(int id)
		{
			return _agentDal.GetById(id);
		}

		public void Update(AgentEntity entity)
		{
			_agentDal.Update(entity);
		}
	}
}
