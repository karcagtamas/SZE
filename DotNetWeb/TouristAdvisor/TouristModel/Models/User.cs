using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("Users")]
	public class User : IOid
	{
		[Key]
		public long OID { get; set; }

		[DisplayName("Keresztnév")]
		[MaxLength(100)]
		public string FirstName { get; set; }

		[DisplayName("Vezetéknév")]
		[MaxLength(100)]
		public string LastName { get; set; }

		[DisplayName("Megszólítás")]
		[MaxLength(10)]
		public string Title { get; set; }

		[DisplayName("Feltöltött kép")]
		[MaxLength(5000)]
		public string CoverPhotoPath { get; set; }

		[DisplayName("Felhasználónév")]
		[MaxLength(100)]
		public string UserName { get; set; }
		[MaxLength(500)]
		public string PasswordHash { get; set; }

		[Required]
		public bool IsActive { get; set; }

		public virtual ICollection<Tour> CreatedTours { get; set; }
		public virtual ICollection<Landmark> AddedLandmarks { get; set; }

		public virtual ICollection<LandmarkVisit> VisitedLandmarks { get; set; }
		public virtual ICollection<TourVisit> VisitedTours { get; set; }

	}
}
