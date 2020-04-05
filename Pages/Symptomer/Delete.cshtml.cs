using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SymptomerWebApi.Data;
using SymptomerWebApi.Models;

namespace SymptomerWebApi
{
    public class DeleteModel : PageModel
    {
        private readonly SymptomerWebApi.Data.SymptomerDbContext _context;

        public DeleteModel(SymptomerWebApi.Data.SymptomerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Symptomer Symptomer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Symptomer = await _context.Symptomer.FirstOrDefaultAsync(m => m.Id == id);

            if (Symptomer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Symptomer = await _context.Symptomer.FindAsync(id);

            if (Symptomer != null)
            {
                _context.Symptomer.Remove(Symptomer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
