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
	public class ChangePasswordModel : PageModel
	{
		private IAgentService _agentService;
		public AgentEntity Agent { get; set; }
		public string OldPassword { get; set; }
		public string NewPassword { get; set; }
		public string ConfirmPassword { get; set; }
		public ChangePasswordModel(IAgentService agentService)
		{
			_agentService = agentService;
		}
		public void OnGet()
		{
		}
		public IActionResult OnPost(AgentEntity entity, string OldPassword, string NewPassword, string ConfirmPassword)
		{
			var result = _agentService.GetById(entity.Id);
			if (result.Password == OldPassword)
			{
				if (result.Password != NewPassword)
				{
					if (NewPassword == ConfirmPassword)
					{
						result.Password = ConfirmPassword;
						_agentService.Update(result);
						return new RedirectToPageResult("/Agent/AgentUI");
					}
					ViewData["Message"] = "Yeni �ifrenizi yanl�� girdiniz!!!";
					return Page();
				}
				ViewData["Message"] = "Eski �ifrenizi ile yeni �ifreniz ayn� olamaz!!!";
				return Page();
			}
			ViewData["Message"] = "Eski �ifrenizi yanl�� girdiniz!!!";
			return Page();
		}
	}
}
