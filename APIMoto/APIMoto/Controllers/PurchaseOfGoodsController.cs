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
    public class PurchaseOfGoodsController : ControllerBase
    {
        private readonly MotoEkipContext _context;

        public PurchaseOfGoodsController(MotoEkipContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOfGoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOfGood>>> GetPurchaseOfGoods()
        {
            return await _context.PurchaseOfGoods.ToListAsync();
        }

        // GET: api/PurchaseOfGoods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOfGood>> GetPurchaseOfGood(int? id)
        {
            var purchaseOfGood = await _context.PurchaseOfGoods.FindAsync(id);

            if (purchaseOfGood == null)
            {
                return NotFound();
            }

            return purchaseOfGood;
        }

        // PUT: api/PurchaseOfGoods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOfGood(int? id, PurchaseOfGood purchaseOfGood)
        {
            if (id != purchaseOfGood.IdParachase)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOfGood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOfGoodExists(id))
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

        // POST: api/PurchaseOfGoods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseOfGood>> PostPurchaseOfGood(PurchaseOfGood purchaseOfGood)
        {
            _context.PurchaseOfGoods.Add(purchaseOfGood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOfGood", new { id = purchaseOfGood.IdParachase }, purchaseOfGood);
        }

        // DELETE: api/PurchaseOfGoods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseOfGood(int? id)
        {
            var purchaseOfGood = await _context.PurchaseOfGoods.FindAsync(id);
            if (purchaseOfGood == null)
            {
                return NotFound();
            }

            _context.PurchaseOfGoods.Remove(purchaseOfGood);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseOfGoodExists(int? id)
        {
            return _context.PurchaseOfGoods.Any(e => e.IdParachase == id);
        }
    }
}
