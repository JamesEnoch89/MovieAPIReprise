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
    public class MovieFactoryController : ApiController
    {
        public IHttpActionResult Post(Movie data)
        {
            var newMovie = new MoviesContext();
            {
                newMovie.Movies.Add(data);
                newMovie.SaveChanges();
                return Ok(data);
            }
        }
    }
}
