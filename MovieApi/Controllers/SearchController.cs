using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieApi.Data;
using MovieApi.Models;

namespace MovieApi.Controllers
{
    public class SearchController : ApiController
    {
        public IEnumerable<Movie> Get(string title)
        {
            var db = new MoviesContext();
            var findTitle = db.Movies.Where(w => w.Title == title);
            return findTitle;
        }
        [HttpGet]
        public IEnumerable<Movie> GetMovie(string genre)
        {
            var db = new MoviesContext();
            var findGenre = db.Movies.Where(w => w.Genre == genre);
            return findGenre;
        }
    }
}
