using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("LandmarkDescriptions")]
	public class LandmarkDescription : IOid
	{
		[Key]
		public long OID { get; set; }
		[MaxLength(200)]
		public string Name { get; set; }
		[MaxLength(1000)]
		public string Summary { get; set; }
		[MaxLength(5000)]
		public string Description { get; set; }
		public long LanguageOID { get; set; }
		[ForeignKey("LanguageOID")]
		public virtual Language Language { get; set; }
		public long LandmarkOID { get; set; }
		[ForeignKey("LandmarkOID")]
		public virtual Landmark Landmark { get; set; }
	}
}
