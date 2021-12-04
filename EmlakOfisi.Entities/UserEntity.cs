using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmlakOfisi.Entities
{
	[Table("Users")]
	public class UserEntity
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
		public bool IsDeleted { get; set; }
		public bool IsAdmin { get; set; }
	}
}
