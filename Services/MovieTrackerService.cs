using Microsoft.EntityFrameworkCore;
using MovieWatcher.Server.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatcher.Server.Services
{
    public class MovieTrackerService : IMovieTrackerService
    {
        private readonly MovieTrackerContext _context;

        public MovieTrackerService(MovieTrackerContext context)
        {
            this._context = context;
        }

        public async Task<List<Movie>> GetMovies() => await this._context.Movies.ToListAsync();

        public async Task<Movie> GetMovie(int id) => await this._context.Movies.Where(m => m.Id == id).FirstOrDefaultAsync();

        public async Task<Movie> CreateMovie(Movie movie)
        {
            await this._context.Movies.AddAsync(movie);
            await this._context.SaveChangesAsync();

            return movie;
        }

        public async Task DeleteMovie(Movie movie)
        {
            this._context.Movies.Remove(movie);
            await this._context.SaveChangesAsync();
        }

        public async Task<List<Movie>> SearchMovies(string term)
        {
            var query = this._context.Movies.AsQueryable();

            if (!string.IsNullOrEmpty(term))
            {
                var cleanTerm = term.ToLowerInvariant().Trim();
                query = query.Where(m => m.Title.ToLowerInvariant().Contains(cleanTerm) || (m.Genre != null && m.Genre.ToLowerInvariant().Contains(cleanTerm)));
            }

            return await query.ToListAsync();
        }

        public async Task UpdateMovie(Movie movie)
        {
            this._context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
