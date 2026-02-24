using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("TourVisit")]
	public class TourVisit : IOid
	{
		[Key]
		public long OID { get; set; }
		public long TourOID { get; set; }
		[ForeignKey("TourOID")]
		public virtual Tour Tour { get; set; }
		public long UserOID { get; set; }
		[ForeignKey("UserOID")]
		public virtual User User { get; set; }
		public DateTime VisitedAt { get; set; }
	}
}
