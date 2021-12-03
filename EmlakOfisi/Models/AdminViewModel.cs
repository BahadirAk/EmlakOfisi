using EmlakOfisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmlakOfisi.Models
{
	public class AdminViewModel
	{
		public AdminViewModel()
		{
			Admins = new List<AdminEntity>();
		}
		public AdminEntity Admin { get; set; }
		public List<AdminEntity> Admins { get; set; }
	}
}
