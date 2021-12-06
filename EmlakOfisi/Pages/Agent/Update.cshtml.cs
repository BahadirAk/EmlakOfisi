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
    public class UpdateModel : PageModel
    {
        private IAdService _adService;
        private IAgentService _agentService;
		public AdEntity Ad { get; set; }
		public AgentEntity Agent { get; set; }
		public UpdateModel(IAdService adService, IAgentService agentService)
		{
            _adService = adService;
            _agentService = agentService;
		}
		public void OnGet(int id)
        {
			Agent = _agentService.Find(x => x.Username == MyClaimTypes.CurrentUser.Username);
			Ad = _adService.GetById(id);
		}
        public IActionResult OnPost(AdEntity ad)
		{
			Agent = _agentService.Find(x => x.Username == MyClaimTypes.CurrentUser.Username);
			var result = _adService.GetById(ad.Id);
			result.ImagePath = ad.ImagePath;
			result.Name = ad.Name;
			result.PropertyType = ad.PropertyType;
			result.Status = ad.Status;
			result.M2 = ad.M2;
			result.NumberOfRooms = ad.NumberOfRooms;
			result.Price = ad.Price;
			_adService.Update(result);
			return RedirectToPage("/Agent/MyAds", new { Id = Agent.Id });
		}
    }
}
