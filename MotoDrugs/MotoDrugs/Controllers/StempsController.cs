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
    public class StempsController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public StempsController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/Stemps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stemp>>> GetStemps()
        {
            return await _context.Stemps.ToListAsync();
        }

        // GET: api/Stemps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stemp>> GetStemp(int id)
        {
            var stemp = await _context.Stemps.FindAsync(id);

            if (stemp == null)
            {
                return NotFound();
            }

            return stemp;
        }

        // PUT: api/Stemps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStemp(int id, Stemp stemp)
        {
            if (id != stemp.IdStemp)
            {
                return BadRequest();
            }

            _context.Entry(stemp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StempExists(id))
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

        // POST: api/Stemps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Stemp>> PostStemp(Stemp stemp)
        {
            _context.Stemps.Add(stemp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStemp", new { id = stemp.IdStemp }, stemp);
        }

        // DELETE: api/Stemps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Stemp>> DeleteStemp(int id)
        {
            var stemp = await _context.Stemps.FindAsync(id);
            if (stemp == null)
            {
                return NotFound();
            }

            _context.Stemps.Remove(stemp);
            await _context.SaveChangesAsync();

            return stemp;
        }

        private bool StempExists(int id)
        {
            return _context.Stemps.Any(e => e.IdStemp == id);
        }
    }
}
