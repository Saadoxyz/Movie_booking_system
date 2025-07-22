using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using hey.Models;

namespace hey.Data
{
    public class heyContext : DbContext
    {
        public heyContext (DbContextOptions<heyContext> options)
            : base(options)
        {
        }

        public DbSet<hey.Models.Movie> Movie { get; set; } = default!;
    }
}
