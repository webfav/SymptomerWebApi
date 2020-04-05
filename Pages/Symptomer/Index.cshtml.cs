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
    public class IndexModel : PageModel
    {
        private readonly SymptomerWebApi.Data.SymptomerDbContext _context;

        public IndexModel(SymptomerWebApi.Data.SymptomerDbContext context)
        {
            _context = context;
        }

        public IList<Symptomer> Symptomer { get;set; }

        public async Task OnGetAsync()
        {
            Symptomer = await _context.Symptomer.ToListAsync();
        }
    }
}
