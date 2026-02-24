using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("Cities")]
	public class City : IOid
	{
		[Key]
		public long OID { get; set; }
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }
		[Required]
		public double Longitude { get; set; }
		[Required]
		public double Latitude { get; set; }
		[MaxLength(5000)]
		public string CoverPhotoPath { get; set; }
		public long CountryOID { get; set; }
		[ForeignKey("CountryOID")]
		public virtual Country Country { get; set; }
	}
}
