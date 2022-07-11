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
    public class ItemsChequeEkipsController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public ItemsChequeEkipsController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/ItemsChequeEkips
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemsChequeEkip>>> GetItemsChequeEkips()
        {
            return await _context.ItemsChequeEkips.ToListAsync();
        }

        // GET: api/ItemsChequeEkips/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemsChequeEkip>> GetItemsChequeEkip(int id)
        {
            var itemsChequeEkip = await _context.ItemsChequeEkips.FindAsync(id);

            if (itemsChequeEkip == null)
            {
                return NotFound();
            }

            return itemsChequeEkip;
        }

        // PUT: api/ItemsChequeEkips/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemsChequeEkip(int id, ItemsChequeEkip itemsChequeEkip)
        {
            if (id != itemsChequeEkip.IdItemsChequeEkip)
            {
                return BadRequest();
            }

            _context.Entry(itemsChequeEkip).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemsChequeEkipExists(id))
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

        // POST: api/ItemsChequeEkips
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemsChequeEkip>> PostItemsChequeEkip(ItemsChequeEkip itemsChequeEkip)
        {
            _context.ItemsChequeEkips.Add(itemsChequeEkip);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemsChequeEkip", new { id = itemsChequeEkip.IdItemsChequeEkip }, itemsChequeEkip);
        }

        // DELETE: api/ItemsChequeEkips/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemsChequeEkip>> DeleteItemsChequeEkip(int id)
        {
            var itemsChequeEkip = await _context.ItemsChequeEkips.FindAsync(id);
            if (itemsChequeEkip == null)
            {
                return NotFound();
            }

            _context.ItemsChequeEkips.Remove(itemsChequeEkip);
            await _context.SaveChangesAsync();

            return itemsChequeEkip;
        }

        private bool ItemsChequeEkipExists(int id)
        {
            return _context.ItemsChequeEkips.Any(e => e.IdItemsChequeEkip == id);
        }
    }
}
