using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("Ratings")]
	public class Rating : IOid
	{
		[Key]
		public long OID { get; set; }
		public long LanguageOID { get; set; }
		[ForeignKey("LanguageOID")]
		public virtual Language Language { get; set; }
		[Required]
		public byte Stars { get; set; }
		[MaxLength(200)]
		public string Title { get; set; }
		[MaxLength(5000)]
		public string Description { get; set; }

		public long? LandmarkOID { get; set; }
		[ForeignKey("LandmarkOID")]
		public virtual Landmark Landmark { get; set; }
		public long? TourOID { get; set; }
		[ForeignKey("TourOID")]
		public virtual Tour Tour { get; set; }
		[Required]
		public DateTime CreatedAt { get; set; }
		public long UserOID { get; set; }
		[ForeignKey("UserOID")]
		public virtual User User { get; set; }
	}
}
