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
    public class EquipmentShowcasesController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public EquipmentShowcasesController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/EquipmentShowcases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipmentShowcase>>> GetEquipmentShowcases()
        {
            return await _context.EquipmentShowcases.ToListAsync();
        }

        // GET: api/EquipmentShowcases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EquipmentShowcase>> GetEquipmentShowcase(int id)
        {
            var equipmentShowcase = await _context.EquipmentShowcases.FindAsync(id);

            if (equipmentShowcase == null)
            {
                return NotFound();
            }

            return equipmentShowcase;
        }

        // PUT: api/EquipmentShowcases/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipmentShowcase(int id, EquipmentShowcase equipmentShowcase)
        {
            if (id != equipmentShowcase.IdEquipmentShowcase)
            {
                return BadRequest();
            }

            _context.Entry(equipmentShowcase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentShowcaseExists(id))
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

        // POST: api/EquipmentShowcases
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EquipmentShowcase>> PostEquipmentShowcase(EquipmentShowcase equipmentShowcase)
        {
            _context.EquipmentShowcases.Add(equipmentShowcase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipmentShowcase", new { id = equipmentShowcase.IdEquipmentShowcase }, equipmentShowcase);
        }

        // DELETE: api/EquipmentShowcases/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EquipmentShowcase>> DeleteEquipmentShowcase(int id)
        {
            var equipmentShowcase = await _context.EquipmentShowcases.FindAsync(id);
            if (equipmentShowcase == null)
            {
                return NotFound();
            }

            _context.EquipmentShowcases.Remove(equipmentShowcase);
            await _context.SaveChangesAsync();

            return equipmentShowcase;
        }

        private bool EquipmentShowcaseExists(int id)
        {
            return _context.EquipmentShowcases.Any(e => e.IdEquipmentShowcase == id);
        }
    }
}
