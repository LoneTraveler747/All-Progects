using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotoDrugs.Models;

namespace MotoDrugs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChequeTechesController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public ChequeTechesController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/ChequeTeches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChequeTech>>> GetChequeTeches()
        {
            return await _context.ChequeTeches.ToListAsync();
        }

        // GET: api/ChequeTeches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChequeTech>> GetChequeTech(int id)
        {
            var chequeTech = await _context.ChequeTeches.FindAsync(id);

            if (chequeTech == null)
            {
                return NotFound();
            }

            return chequeTech;
        }

        // PUT: api/ChequeTeches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChequeTech(int id, ChequeTech chequeTech)
        {
            if (id != chequeTech.IdChequeTech)
            {
                return BadRequest();
            }

            _context.Entry(chequeTech).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChequeTechExists(id))
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

        // POST: api/ChequeTeches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChequeTech>> PostChequeTech(ChequeTech chequeTech)
        {
            _context.ChequeTeches.Add(chequeTech);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChequeTech", new { id = chequeTech.IdChequeTech }, chequeTech);
        }

        // DELETE: api/ChequeTeches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChequeTech>> DeleteChequeTech(int id)
        {
            var chequeTech = await _context.ChequeTeches.FindAsync(id);
            if (chequeTech == null)
            {
                return NotFound();
            }

            _context.ChequeTeches.Remove(chequeTech);
            await _context.SaveChangesAsync();

            return chequeTech;
        }

        private bool ChequeTechExists(int id)
        {
            return _context.ChequeTeches.Any(e => e.IdChequeTech == id);
        }
    }
}
