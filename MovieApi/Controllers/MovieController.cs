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
    public class MovieController : ApiController
    {
        public IEnumerable<Movie> Get()
        {
            var db = new MoviesContext();
            return db.Movies.ToList();
        }
    }
}
