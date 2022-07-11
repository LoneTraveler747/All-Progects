using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AZSAPI.Models;

namespace AZSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefillsController : ControllerBase
    {
        private readonly AZS2Context _context;

        public RefillsController(AZS2Context context)
        {
            _context = context;
        }

        // GET: api/Refills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Refill>>> GetRefills()
        {
            return await _context.Refills.ToListAsync();
        }

        // GET: api/Refills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Refill>> GetRefill(int id)
        {
            var refill = await _context.Refills.FindAsync(id);

            if (refill == null)
            {
                return NotFound();
            }

            return refill;
        }

        // PUT: api/Refills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRefill(int id, Refill refill)
        {
            if (id != refill.IdRefill)
            {
                return BadRequest();
            }

            _context.Entry(refill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RefillExists(id))
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

        // POST: api/Refills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Refill>> PostRefill(Refill[] refill)
        {


            _context.Refills.AddRange(refill);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRefill", new { id = refill.First().IdRefill }, refill);
        }

        // DELETE: api/Refills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRefill(int id)
        {
            var refill = await _context.Refills.FindAsync(id);
            if (refill == null)
            {
                return NotFound();
            }

            _context.Refills.Remove(refill);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RefillExists(int id)
        {
            return _context.Refills.Any(e => e.IdRefill == id);
        }
    }
}
