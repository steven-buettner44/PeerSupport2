using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeerSupport2.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string City { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Day { get; set; }

        public int Hours { get; set; }

        public int Minutes { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

    }
}
