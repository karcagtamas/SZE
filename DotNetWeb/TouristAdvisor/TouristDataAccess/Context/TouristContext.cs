using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TouristModel.Models;

namespace TouristDataAccess.Context
{
	public class TouristContext : DbContext
	{
		public DbSet<City> Cities { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<GalleryItem> GalleryItems { get; set; }
		public DbSet<Landmark> Landmarks { get; set; }
		public DbSet<LandmarkDescription> LandmarkDescriptions { get; set; }
		public DbSet<LandmarkGallery> LandmarkGalleries { get; set; }
		public DbSet<LandmarkVisit> LandmarkVisits { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<Rating> Ratings { get; set; }
		public DbSet<Tour> Tours { get; set; }
		public DbSet<TourLandmark> TourLandmarks { get; set; }
		public DbSet<TourVisit> TourVisits { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(TouristDbConfiguration.GetConnectionString());
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
			.HasMany(e => e.VisitedTours)
			.WithOne(e => e.User)
			.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<User>()
			.HasMany(e => e.VisitedLandmarks)
			.WithOne(e => e.User)
			.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<Tour>()
			.HasMany(e => e.Ratings)
			.WithOne(e => e.Tour)
			.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<Landmark>()
			.HasMany(e => e.Ratings)
			.WithOne(e => e.Landmark)
			.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<Tour>()
			.HasMany(e => e.TourLandmarks)
			.WithOne(e => e.Tour)
			.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
