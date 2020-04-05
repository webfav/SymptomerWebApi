using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SymptomerWebApi.Data;
using SymptomerWebApi.Models;

namespace SymptomerWebApi
{
    public class CreateModel : PageModel
    {
        private readonly SymptomerWebApi.Data.SymptomerDbContext _context;

        public CreateModel(SymptomerWebApi.Data.SymptomerDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Symptomer Symptomer { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Symptomer.Add(Symptomer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
