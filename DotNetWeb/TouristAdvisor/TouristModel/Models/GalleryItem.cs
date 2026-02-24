using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TouristModel.Interfaces;

namespace TouristModel.Models
{
	[Table("GalleryItems")]
	public class GalleryItem : IOid
	{
		[Key]
		public long OID { get; set; }
		[MaxLength(5000)]
		public string Path { get; set; }
		[MaxLength(5000)]
		public string Description { get; set; }
		public long LanguageOID { get; set; }
		[ForeignKey("LanguageOID")]
		public virtual Language Language { get; set; }
		public long LandmarkGalleryOID { get; set; }
		[ForeignKey("LandmarkGalleryOID")]
		public virtual LandmarkGallery LandmarkGallery { get; set; }
	}
}
