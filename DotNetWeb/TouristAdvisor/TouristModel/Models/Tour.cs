using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("Tours")]
	public class Tour : IOid
	{
		[Key]
		public long OID { get; set; }
		public long LanguageOID { get; set; }
		[ForeignKey("LanguageOID")]
		public virtual Language Language { get; set; }
		[MaxLength(200)]
		public string Name { get; set; }
		[MaxLength(1000)]
		public string Summary { get; set; }
		[MaxLength(5000)]
		public string Description { get; set; }
		public int DurationMinutes { get; set; }
		[MaxLength(5000)]
		public string CoverPhotoPath { get; set; }
		[MaxLength(2)]
		public string DifficulutyCode { get; set; }
		public virtual ICollection<TourLandmark> TourLandmarks { get; set; }
		public virtual ICollection<Rating> Ratings { get; set; }
		public long UserOID { get; set; }
		[ForeignKey("UserOID")]
		public virtual User CreatedByUser { get; set; }
	}
}
