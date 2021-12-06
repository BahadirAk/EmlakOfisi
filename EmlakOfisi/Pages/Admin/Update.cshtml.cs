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
    public class UpdateModel : PageModel
    {
        private IAgentService _agentService;
		public AgentEntity Agent { get; set; }
		public UpdateModel(IAgentService agentService)
		{
            _agentService = agentService;

		}
        public void OnGet(int id)
        {
            Agent = _agentService.GetById(id);
        }
        public IActionResult OnPost(AgentEntity agent)
		{
            var result = _agentService.GetById(agent.Id);
            result.Name = agent.Name;
            result.Username = agent.Username;
            result.Password = agent.Password;
            _agentService.Update(result);
            return new RedirectToPageResult("/Admin/AdminUI");
		}
    }
}
