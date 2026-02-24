using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("Languages")]
	public class Language : IOid
	{
		[Key]
		public long OID { get; set; }
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }
		[MaxLength(5000)]
		public string IconPath { get; set; }
	}
}
