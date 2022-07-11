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
    public class ItemIncomingsController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public ItemIncomingsController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/ItemIncomings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemIncoming>>> GetItemIncomings()
        {
            return await _context.ItemIncomings.ToListAsync();
        }

        // GET: api/ItemIncomings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemIncoming>> GetItemIncoming(int id)
        {
            var itemIncoming = await _context.ItemIncomings.FindAsync(id);

            if (itemIncoming == null)
            {
                return NotFound();
            }

            return itemIncoming;
        }

        // PUT: api/ItemIncomings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemIncoming(int id, ItemIncoming itemIncoming)
        {
            if (id != itemIncoming.IdIncoming)
            {
                return BadRequest();
            }

            _context.Entry(itemIncoming).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemIncomingExists(id))
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

        // POST: api/ItemIncomings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemIncoming>> PostItemIncoming(ItemIncoming itemIncoming)
        {
            _context.ItemIncomings.Add(itemIncoming);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemIncoming", new { id = itemIncoming.IdIncoming }, itemIncoming);
        }

        // DELETE: api/ItemIncomings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemIncoming>> DeleteItemIncoming(int id)
        {
            var itemIncoming = await _context.ItemIncomings.FindAsync(id);
            if (itemIncoming == null)
            {
                return NotFound();
            }

            _context.ItemIncomings.Remove(itemIncoming);
            await _context.SaveChangesAsync();

            return itemIncoming;
        }

        private bool ItemIncomingExists(int id)
        {
            return _context.ItemIncomings.Any(e => e.IdIncoming == id);
        }
    }
}
