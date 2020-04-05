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
    public class DetailsModel : PageModel
    {
        private readonly SymptomerWebApi.Data.SymptomerDbContext _context;

        public DetailsModel(SymptomerWebApi.Data.SymptomerDbContext context)
        {
            _context = context;
        }

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
    }
}
