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
    public class VacantionsController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public VacantionsController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/Vacantions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vacantion>>> GetVacantions()
        {
            return await _context.Vacantions.ToListAsync();
        }

        // GET: api/Vacantions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vacantion>> GetVacantion(int id)
        {
            var vacantion = await _context.Vacantions.FindAsync(id);

            if (vacantion == null)
            {
                return NotFound();
            }

            return vacantion;
        }

        // PUT: api/Vacantions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVacantion(int id, Vacantion vacantion)
        {
            if (id != vacantion.IdVacation)
            {
                return BadRequest();
            }

            _context.Entry(vacantion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VacantionExists(id))
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

        // POST: api/Vacantions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Vacantion>> PostVacantion(Vacantion vacantion)
        {
            _context.Vacantions.Add(vacantion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVacantion", new { id = vacantion.IdVacation }, vacantion);
        }

        // DELETE: api/Vacantions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vacantion>> DeleteVacantion(int id)
        {
            var vacantion = await _context.Vacantions.FindAsync(id);
            if (vacantion == null)
            {
                return NotFound();
            }

            _context.Vacantions.Remove(vacantion);
            await _context.SaveChangesAsync();

            return vacantion;
        }

        private bool VacantionExists(int id)
        {
            return _context.Vacantions.Any(e => e.IdVacation == id);
        }
    }
}
