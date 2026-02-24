using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("TourLandmarks")]
	public class TourLandmark : IOid
	{
		[Key]
		public long OID { get; set; }
		public long LandmarkOID { get; set; }
		[ForeignKey("LandmarkOID")]
		public virtual Landmark Landmark { get; set; }
		public long TourOID { get; set; }
		[ForeignKey("TourOID")]
		public virtual Tour Tour { get; set; }
	}
}
