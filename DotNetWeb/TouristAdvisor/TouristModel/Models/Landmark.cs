using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("Landmarks")]
	public class Landmark : IOid
	{
		[Key]
		public long OID { get; set; }
		[Required]
		public double Longitude { get; set; }
		[Required]
		public double Latitude { get; set; }
		[MaxLength(5000)]
		public string CoverPhotoPath { get; set; }
		public virtual ICollection<LandmarkDescription> LandmarkDescriptions { get; set; }
		[Required]
		[MaxLength(4)]
		public string LandmarkCategoryCode { get; set; }
		public long CityOID { get; set; }
		[ForeignKey("CityOID")]
		public virtual City City { get; set; }
		public virtual ICollection<Rating> Ratings { get; set; }
		public long UserOID { get; set; }
		[ForeignKey("UserOID")]
		public virtual User AddedBy { get; set; }
	}
}
