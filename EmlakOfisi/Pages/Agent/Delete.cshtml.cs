using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmlakOfisi.Pages.Agent
{
    public class DeleteModel : PageModel
    {
        private IAdService _adService;
        private IAgentService _agentService;
		public AdEntity Ad { get; set; }
		public AgentEntity Agent { get; set; }
		public DeleteModel(IAdService adService, IAgentService agentService)
		{
            _adService = adService;
            _agentService = agentService;
		}
		public void OnGet(int id)
        {
            Ad = _adService.GetById(id);
            Agent = _agentService.Find(x => x.Username == MyClaimTypes.CurrentUser.Username);
        }
        public IActionResult OnPost(AdEntity entity)
		{
            Agent = _agentService.Find(x => x.Username == MyClaimTypes.CurrentUser.Username);
            var result = _adService.GetById(entity.Id);
            result.IsDeleted = true;
            _adService.Delete(result);
            return RedirectToPage("/Agent/MyAds", new { Id = Agent.Id });
        }
    }
}
