using System.Threading.Tasks;
using HomeWork1_RazorPagesMovies.Data;
using HomeWork1_RazorPagesMovies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HomeWork1_RazorPagesMovies.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMoviesContext _context;

        public DetailsModel(RazorPagesMoviesContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
