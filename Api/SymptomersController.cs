using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SymptomerWebApi.Data;
using SymptomerWebApi.Models;

namespace SymptomerWebApi.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SymptomersController : ControllerBase
    {
        private readonly SymptomerDbContext _context;

        public SymptomersController(SymptomerDbContext context)
        {
            _context = context;
        }

        // GET: api/Symptomers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Symptomer>>> GetSymptomer()
        {
            return await _context.Symptomer.ToListAsync();
        }

        // GET: api/Symptomers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Symptomer>> GetSymptomer(int id)
        {
            var symptomer = await _context.Symptomer.FindAsync(id);

            if (symptomer == null)
            {
                return NotFound();
            }

            return symptomer;
        }

        // PUT: api/Symptomers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSymptomer(int id, Symptomer symptomer)
        {
            if (id != symptomer.Id)
            {
                return BadRequest();
            }

            _context.Entry(symptomer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SymptomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Symptomers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Symptomer>> PostSymptomer(Symptomer symptomer)
        {
            _context.Symptomer.Add(symptomer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSymptomer", new { id = symptomer.Id }, symptomer);
        }

        // DELETE: api/Symptomers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Symptomer>> DeleteSymptomer(int id)
        {
            var symptomer = await _context.Symptomer.FindAsync(id);
            if (symptomer == null)
            {
                return NotFound();
            }

            _context.Symptomer.Remove(symptomer);
            await _context.SaveChangesAsync();

            return symptomer;
        }

        private bool SymptomerExists(int id)
        {
            return _context.Symptomer.Any(e => e.Id == id);
        }
    }
}
