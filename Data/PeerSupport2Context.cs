using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeerSupport2.Models;

namespace PeerSupport2.Data
{
    public class PeerSupport2Context : DbContext
    {
        public PeerSupport2Context (DbContextOptions<PeerSupport2Context> options)
            : base(options)
        {
        }

        public DbSet<PeerSupport2.Models.Movie> Movie { get; set; }
    }
}
