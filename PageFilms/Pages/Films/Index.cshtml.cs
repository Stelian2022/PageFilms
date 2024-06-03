using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PageFilms.Data;
using PageFilms.Models;

namespace PageFilms.Pages.Films
{
    public class IndexModel : PageModel
    {
        private readonly PageFilms.Data.PageFilmsContext _context;

        public IndexModel(PageFilms.Data.PageFilmsContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Film = await _context.Film.ToListAsync();
        }
    }
}
