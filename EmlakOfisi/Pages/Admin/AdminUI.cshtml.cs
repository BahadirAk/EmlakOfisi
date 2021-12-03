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
		private IAgentManager _agentManager;
		public List<AgentEntity> Agents { get; set; }
		public AdminUIModel(IAgentManager agentManager)
		{
			_agentManager = agentManager;
		}
		public void OnGet()
		{
			//AdminViewModel adminViewModel = new AdminViewModel();
			Agents = _agentManager.GetAllByFilter(x => x.IsDeleted == false);
			//AdminViewModel.Admin = admin;
		}
	}
}
