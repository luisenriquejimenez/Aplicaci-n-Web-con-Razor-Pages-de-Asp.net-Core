using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }

        public class IndexModel : PageModel
    {
         private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;
        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
    {
         _context = context;
    }


