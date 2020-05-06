using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Necula_Alexandru_Rp.Models.Models;

namespace Asp_Necula_Alexandru_Rp.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Necula_Alexandru_Rp.Models.Models.Movie> Movie { get; set; }
    }
}
