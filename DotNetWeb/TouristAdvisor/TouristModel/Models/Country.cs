using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("Countries")]
	public class Country : IOid
	{
		[Key]
		public long OID { get; set; }
		[MaxLength(3)]
		public string Abbreviation { get; set; }
		[MaxLength(100)]
		public string Name { get; set; }
		[MaxLength(5000)]
		public string CoverPhotoPath { get; set; }

		public virtual ICollection<City> Cities { get; set; }
	}
}
