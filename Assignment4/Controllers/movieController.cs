using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment4.Controllers
{
    public class movieController : ApiController
    {
        public class Movie
        {
            public String m_id;
            public String m_name;
            public String m_cast;

        }
        static List<Movie> movies = new List<Movie>();

        public List<Movie> GetAll()
        {
            return movies;
        }

        public String PostMovie(Movie m)
        {
            movies.Add(m);
            return "Movie Added Successfully";
        }

        public String PatchMovie(Movie m, int index)
        {
            movies[index] = m;
            return "Movie Updated Successfully";
        }
        public String DeleteMovie(int index)
        {
            movies.RemoveAt(index);
            return "Movie Deleted Successfully";
        }



    }
}
