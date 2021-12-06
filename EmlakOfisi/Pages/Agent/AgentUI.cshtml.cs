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
    public class AgentUIModel : PageModel
    {
        private IAdService _adService;
        private IAgentService _agentService;
        public List<AdEntity> Ads { get; set; }
		public AgentEntity Agent { get; set; }
		public AgentUIModel(IAdService adService, IAgentService agentService)
		{
            _adService = adService;
            _agentService = agentService;
		}
		public void OnGet()
        {
            var user = MyClaimTypes.CurrentUser;
            Agent = _agentService.Find(x => x.Username == user.Username);
            Ads = _adService.GetAllByFilter(x => x.IsDeleted == false);
        }
    }
}
