using System;
using System.Collections.Generic;
using System.Text;

namespace Omdbapi.Core.Model.ResponseModel
{
    public class OmdbApiModel
    {
        public List<Search> search { get; set; }
    }

    public class Search
    {
        public string Title { get; set; }

        public string Year { get; set; }

        public string imdbID { get; set; }

        public string Type { get; set; }

        public string Poster { get; set; }
    }

}
