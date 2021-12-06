using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmlakOfisi.Bll.Abstract;
using EmlakOfisi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmlakOfisi.Pages.Login
{
	public class LoginModel : PageModel
	{
		private IUserService _userService;
		public UserEntity User { get; set; }
		public LoginModel(IUserService userService)
		{
			_userService = userService;
		}
		public IActionResult OnPost(UserEntity user)
		{
			//ModelState.IsValid eklenecek
			var result = _userService.Find(x => x.Username == user.Username);
			MyClaimTypes.CurrentUser = _userService.GetById(result.Id);
			if (result != null)
			{
				if(result.Username == user.Username && result.Password == user.Password)
				{
					if(result.IsAdmin == true)
					{
						return new RedirectToPageResult("/Admin/AdminUI");
					}
					else
					{
						return new RedirectToPageResult("/Agent/AgentUI");
					}
				}
				else
				{
					return Page();
				}
			}
			else
			{
				return Page();
			}
		}
	}
}