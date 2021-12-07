using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

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
		public void OnGet(string searchText, string propertyType, string status)
		{
			var user = MyClaimTypes.CurrentUser;
			Agent = _agentService.Find(x => x.Username == user.Username);
			if (searchText != null)
			{
				Ads = _adService.GetAllByFilter(x => x.IsDeleted == false).Where(x => x.Name.ToLower().Contains(searchText)).ToList();
			}
			else if(propertyType != null)
			{
				Ads = _adService.GetAllByFilter(x => x.IsDeleted == false).Where(x => x.PropertyType == propertyType).ToList();
			}
			else if(status != null)
			{
				Ads = _adService.GetAllByFilter(x => x.IsDeleted == false).Where(x => x.Status == status).ToList();
			}
			else
			{
				Ads = _adService.GetAllByFilter(x => x.IsDeleted == false);
			}
		}
	}
}
