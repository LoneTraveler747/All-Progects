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
    public class ItemInformationsController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public ItemInformationsController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/ItemInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemInformation>>> GetItemInformations()
        {
            return await _context.ItemInformations.ToListAsync();
        }

        // GET: api/ItemInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemInformation>> GetItemInformation(int id)
        {
            var itemInformation = await _context.ItemInformations.FindAsync(id);

            if (itemInformation == null)
            {
                return NotFound();
            }

            return itemInformation;
        }

        // PUT: api/ItemInformations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemInformation(int id, ItemInformation itemInformation)
        {
            if (id != itemInformation.IdEquipment)
            {
                return BadRequest();
            }

            _context.Entry(itemInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemInformationExists(id))
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

        // POST: api/ItemInformations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ItemInformation>> PostItemInformation(ItemInformation itemInformation)
        {
            _context.ItemInformations.Add(itemInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemInformation", new { id = itemInformation.IdEquipment }, itemInformation);
        }

        // DELETE: api/ItemInformations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemInformation>> DeleteItemInformation(int id)
        {
            var itemInformation = await _context.ItemInformations.FindAsync(id);
            if (itemInformation == null)
            {
                return NotFound();
            }

            _context.ItemInformations.Remove(itemInformation);
            await _context.SaveChangesAsync();

            return itemInformation;
        }

        private bool ItemInformationExists(int id)
        {
            return _context.ItemInformations.Any(e => e.IdEquipment == id);
        }
    }
}
