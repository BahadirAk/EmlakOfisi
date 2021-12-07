using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmlakOfisi.Pages.Admin
{
	public class AddModel : PageModel
	{
		private IAgentService _agentService;
		public AgentEntity Agent { get; set; }
		public AddModel(IAgentService agentService)
		{
			_agentService = agentService;
		}
		public void OnGet()
		{
		}
		public IActionResult OnPost(AgentEntity agent)
		{
			if (ModelState.IsValid)
			{
				AgentEntity entity = new AgentEntity();
				entity.Name = agent.Name;
				entity.Username = agent.Username;
				entity.Password = agent.Password == null ? "123456" : agent.Password;
				entity.IsDeleted = false;
				_agentService.Add(entity);
				return new RedirectToPageResult("/Admin/AdminUI");
			}
			return Page();
		}
	}
}
