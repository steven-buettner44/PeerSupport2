using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PeerSupport2.Data;
using PeerSupport2.Models;

namespace PeerSupport2.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly PeerSupport2.Data.PeerSupport2Context _context;

        public IndexModel(PeerSupport2.Data.PeerSupport2Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
