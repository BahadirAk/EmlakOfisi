using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmlakOfisi.Entities
{
	[Table("Ads")]
	public class AdEntity
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public Guid No { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string PropertyType { get; set; }
		[Required]
		public string Status { get; set; }
		public string M2 { get; set; }
		public string NumberOfRooms { get; set; }
		public string ImagePath { get; set; }
		public double Price { get; set; }
		public bool IsDeleted { get; set; }

		public int AgentId { get; set; }
		public virtual AgentEntity AgentEntity { get; set; }
	}
}
