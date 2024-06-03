using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PageFilms.Models;

namespace PageFilms.Data
{
    public class PageFilmsContext : DbContext
    {
        public PageFilmsContext (DbContextOptions<PageFilmsContext> options)
            : base(options)
        {
        }

        public DbSet<PageFilms.Models.Film> Film { get; set; } = default!;
    }
}
