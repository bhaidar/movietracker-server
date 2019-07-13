using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieWatcher.Server.Models;
using MovieWatcher.Server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieWatcher.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class MovieTrackerController : ControllerBase
    {
        private readonly IMovieTrackerService _service;
        private readonly MovieTrackerContext _context;

        public MovieTrackerController(IMovieTrackerService service, MovieTrackerContext context)
        {
            this._service = service;
            this._context = context;
        }

        [HttpGet("users")]
        public async Task<ActionResult<IEnumerable<String>>> GetUsers()
        {
            return await this._context.Users.Select(u => u.UserName).ToListAsync();
        }


        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Get()
        {
            return await this._service.GetMovies();
        }

        // GET: api/<controller>/search/{title}
        [HttpGet("search/{term?}")]
        public async Task<ActionResult<IEnumerable<Movie>>> SearchMovies(string term)
        {
            return await this._service.SearchMovies(term);
        }


        // GET api/<controller>/5
        [HttpGet("{id}", Name = "GetMovie")]
        public async Task<ActionResult<Movie>> Get(int id)
        {
            var movie = await this._service.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<Movie>> Post(Movie movie)
        {
            await this._service.CreateMovie(movie);
            return CreatedAtRoute("GetMovie", new { id = movie.Id }, movie);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var movie = await this._service.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            await this._service.DeleteMovie(movie);

            return NoContent();
        }

        // PUT api/<controller>/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            await this._service.UpdateMovie(movie);

            return NoContent();
        }
    }
}
