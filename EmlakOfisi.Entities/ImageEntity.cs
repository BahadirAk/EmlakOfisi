using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmlakOfisi.Entities
{
	[Table("Images")]
	public class ImageEntity
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Path { get; set; }

		public int AdId { get; set; }
		public virtual AdEntity AdEntity { get; set; }
	}
}
