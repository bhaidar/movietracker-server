using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatcher.Server.Models
{
    public class MovieTrackerContext : DbContext
    {
        public MovieTrackerContext(DbContextOptions<MovieTrackerContext> options)
           : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.WatchedOn).IsRequired().HasColumnType("date");
                entity.Property(e => e.Rating).HasDefaultValue(0);
            });

            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "The Shawshank Redemption", WatchedOn = new DateTime(2016, 11, 4), Genre = "Drama", Rating = 4 },
                new Movie() { Id = 2, Title = "The Godfather", WatchedOn = new DateTime(2017, 10, 2), Genre = "Drama", Rating = 2 },
                new Movie() { Id = 3, Title = "The Dark Knight", WatchedOn = new DateTime(2018, 12, 1), Genre = "Drama, Action", Rating = 3 },
                new Movie() { Id = 4, Title = "The Godfather: Part II ", WatchedOn = new DateTime(2019, 2, 4), Genre = "Drama", Rating = 1 },
                new Movie() { Id = 5, Title = "The Lord of the Rings: The Return of the King", WatchedOn = new DateTime(2019, 4, 2), Genre = "Adventure, Drama, Fantasy", Rating = 5 },
                new Movie() { Id = 6, Title = "Pulp Fiction", WatchedOn = new DateTime(2019, 3, 27), Genre = "Crime, Drama", Rating = 3});
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
