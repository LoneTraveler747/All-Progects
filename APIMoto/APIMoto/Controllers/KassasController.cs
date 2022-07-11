using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIMoto.Models;

namespace APIMoto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KassasController : ControllerBase
    {
        private readonly MotoEkipContext _context;

        public KassasController(MotoEkipContext context)
        {
            _context = context;
        }

        // GET: api/Kassas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kassa>>> GetKassas()
        {
            return await _context.Kassas.ToListAsync();
        }

        // GET: api/Kassas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kassa>> GetKassa(int? id)
        {
            var kassa = await _context.Kassas.FindAsync(id);

            if (kassa == null)
            {
                return NotFound();
            }

            return kassa;
        }

        // PUT: api/Kassas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKassa(int? id, Kassa kassa)
        {
            if (id != kassa.IdKassa)
            {
                return BadRequest();
            }

            _context.Entry(kassa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KassaExists(id))
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

        // POST: api/Kassas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Kassa>> PostKassa(Kassa kassa)
        {
            _context.Kassas.Add(kassa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKassa", new { id = kassa.IdKassa }, kassa);
        }

        // DELETE: api/Kassas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKassa(int? id)
        {
            var kassa = await _context.Kassas.FindAsync(id);
            if (kassa == null)
            {
                return NotFound();
            }

            _context.Kassas.Remove(kassa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KassaExists(int? id)
        {
            return _context.Kassas.Any(e => e.IdKassa == id);
        }
    }
}
