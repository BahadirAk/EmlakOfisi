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
    public class MyAdsModel : PageModel
    {
        private IAgentService _agentService;
        private IAdService _adService;
		public AgentEntity Agent { get; set; }
		public AdEntity Ad { get; set; }
		public List<AdEntity> Ads { get; set; }
		public MyAdsModel(IAgentService agentService, IAdService adService)
		{
            _agentService = agentService;
            _adService = adService;
		}
		public void OnGet(int id)
        {
            Agent = _agentService.GetById(id);
            Ads = _adService.GetAllByFilter(x => x.AgentEntity == Agent);
        }
    }
}
