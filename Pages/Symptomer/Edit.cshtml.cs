using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SymptomerWebApi.Data;
using SymptomerWebApi.Models;

namespace SymptomerWebApi
{
    public class EditModel : PageModel
    {
        private readonly SymptomerWebApi.Data.SymptomerDbContext _context;

        public EditModel(SymptomerWebApi.Data.SymptomerDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Symptomer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SymptomerExists(Symptomer.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SymptomerExists(int id)
        {
            return _context.Symptomer.Any(e => e.Id == id);
        }
    }
}
