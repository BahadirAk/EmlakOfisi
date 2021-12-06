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
    public class AddModel : PageModel
    {
        private IAdService _adService;
		private IAgentService _agentService;
		public AdEntity Ad { get; set; }
		public AgentEntity Agent { get; set; }
		public AddModel(IAdService adService, IAgentService agentService)
		{
            _adService = adService;
			_agentService = agentService;
		}
		public void OnGet()
        {
			Agent = _agentService.Find(x => x.Username == MyClaimTypes.CurrentUser.Username);
		}
		public IActionResult OnPost(AdEntity ad)
		{
			Agent = _agentService.Find(x => x.Username == MyClaimTypes.CurrentUser.Username);
			//ModelState.IsValid eklenecek
			AdEntity entity = new AdEntity();
			entity.ImagePath = ad.ImagePath == null ? "https://www.kenyons.com/wp-content/uploads/2017/04/default-image-620x600.jpg" : ad.ImagePath;
			entity.No = Guid.NewGuid();
			entity.Name = ad.Name;
			entity.PropertyType = ad.PropertyType;
			entity.Status = ad.Status;
			entity.M2 = ad.M2;
			entity.NumberOfRooms = ad.NumberOfRooms;
			entity.Price = ad.Price;
			entity.IsDeleted = false;
			entity.AgentEntity = Agent;
			_adService.Add(entity);
			return RedirectToPage("/Agent/MyAds", new { Id = Agent.Id });
		}
	}
}
