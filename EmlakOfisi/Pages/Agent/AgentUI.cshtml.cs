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
			var propertyTypeLast = propertyType == null ? "" : propertyType;
			var statusLast = status == null ? "" : status;
			if (searchText != null)
			{
				Ads = _adService.GetAllByFilter(x => x.IsDeleted == false).Where(x => x.Name.ToLower().Contains(searchText) && x.PropertyType.Contains(propertyTypeLast) && x.Status.Contains(statusLast)).ToList();
			}
			else
			{
				Ads = _adService.GetAllByFilter(x => x.IsDeleted == false).Where(x => x.PropertyType.Contains(propertyTypeLast) && x.Status.Contains(statusLast)).ToList();
			}
		}
	}
}
