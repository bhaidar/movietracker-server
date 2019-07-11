using System.Collections.Generic;
using System.Threading.Tasks;
using MovieWatcher.Server.Models;

namespace MovieWatcher.Server.Services
{
    public interface IMovieTrackerService
    {
        Task<Movie> CreateMovie(Movie movie);
        Task DeleteMovie(Movie movie);
        Task<Movie> GetMovie(int id);
        Task<List<Movie>> GetMovies();
        Task<List<Movie>> SearchMovies(string term);
        Task UpdateMovie(Movie movie);
    }
}