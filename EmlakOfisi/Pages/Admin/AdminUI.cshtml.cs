using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Entities;
using EmlakOfisi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmlakOfisi.Pages.Admin
{
	public class AdminUIModel : PageModel
	{
		private IAgentService _agentService;
		public AgentEntity Agent { get; set; }
		public List<AgentEntity> Agents { get; set; }
		public AdminUIModel(IAgentService agentService)
		{
			_agentService = agentService;
		}
		public void OnGet()
		{
			Agents = _agentService.GetAllByFilter(x => x.IsDeleted == false);
		}
	}
}
