using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("LandmarkVisits")]
	public class LandmarkVisit : IOid
	{
		[Key]
		public long OID { get; set; }
		public long LandmarkOID { get; set; }
		[ForeignKey("LandmarkOID")]
		public virtual Landmark Landmark { get; set; }
		public long UserOID { get; set; }
		[ForeignKey("UserOID")]
		public virtual User User { get; set; }
		[Required]
		public virtual DateTime VisitedAt { get; set; }
	}
}
