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
    public class DeleteModel : PageModel
    {
        private IAgentService _agentService;
		public AgentEntity Agent { get; set; }
		public DeleteModel(IAgentService agentService)
		{
            _agentService = agentService;
		}
        public void OnGet(int id)
        {
            Agent = _agentService.GetById(id);
        }
        public IActionResult OnPost(AgentEntity entity)
		{
            var result = _agentService.GetById(entity.Id);
            result.IsDeleted = true;
            _agentService.Delete(result);
            return new RedirectToPageResult("/Admin/AdminUI");
        }
    }
}
