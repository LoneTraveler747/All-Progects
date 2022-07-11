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
    public class NameShopsController : ControllerBase
    {
        private readonly MotoEkipContext _context;

        public NameShopsController(MotoEkipContext context)
        {
            _context = context;
        }

        // GET: api/NameShops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NameShop>>> GetNameShops()
        {
            return await _context.NameShops.ToListAsync();
        }

        // GET: api/NameShops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NameShop>> GetNameShop(int? id)
        {
            var nameShop = await _context.NameShops.FindAsync(id);

            if (nameShop == null)
            {
                return NotFound();
            }

            return nameShop;
        }

        // PUT: api/NameShops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNameShop(int? id, NameShop nameShop)
        {
            if (id != nameShop.IdShop)
            {
                return BadRequest();
            }

            _context.Entry(nameShop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NameShopExists(id))
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

        // POST: api/NameShops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NameShop>> PostNameShop(NameShop nameShop)
        {
            _context.NameShops.Add(nameShop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNameShop", new { id = nameShop.IdShop }, nameShop);
        }

        // DELETE: api/NameShops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNameShop(int? id)
        {
            var nameShop = await _context.NameShops.FindAsync(id);
            if (nameShop == null)
            {
                return NotFound();
            }

            _context.NameShops.Remove(nameShop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NameShopExists(int? id)
        {
            return _context.NameShops.Any(e => e.IdShop == id);
        }
    }
}
