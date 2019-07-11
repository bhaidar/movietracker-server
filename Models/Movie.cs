using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatcher.Server.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime WatchedOn {get ;set;}

        public string Genre { get; set; }

        public int Rating { get; set; }
    }
}
