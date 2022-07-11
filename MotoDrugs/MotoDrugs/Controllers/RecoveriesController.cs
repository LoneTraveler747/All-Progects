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
    public class RecoveriesController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public RecoveriesController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/Recoveries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recovery>>> GetRecoverys()
        {
            return await _context.Recoverys.ToListAsync();
        }

        // GET: api/Recoveries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recovery>> GetRecovery(int id)
        {
            var recovery = await _context.Recoverys.FindAsync(id);

            if (recovery == null)
            {
                return NotFound();
            }

            return recovery;
        }

        // PUT: api/Recoveries/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecovery(int id, Recovery recovery)
        {
            if (id != recovery.IdRecovery)
            {
                return BadRequest();
            }

            _context.Entry(recovery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecoveryExists(id))
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

        // POST: api/Recoveries
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Recovery>> PostRecovery(Recovery recovery)
        {
            _context.Recoverys.Add(recovery);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecovery", new { id = recovery.IdRecovery }, recovery);
        }

        // DELETE: api/Recoveries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Recovery>> DeleteRecovery(int id)
        {
            var recovery = await _context.Recoverys.FindAsync(id);
            if (recovery == null)
            {
                return NotFound();
            }

            _context.Recoverys.Remove(recovery);
            await _context.SaveChangesAsync();

            return recovery;
        }

        private bool RecoveryExists(int id)
        {
            return _context.Recoverys.Any(e => e.IdRecovery == id);
        }
    }
}
