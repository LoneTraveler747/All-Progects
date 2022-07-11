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
    public class ChequeTechPaymentsController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public ChequeTechPaymentsController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/ChequeTechPayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChequeTechPayment>>> GetChequeTechPayments()
        {
            return await _context.ChequeTechPayments.ToListAsync();
        }

        // GET: api/ChequeTechPayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChequeTechPayment>> GetChequeTechPayment(int id)
        {
            var chequeTechPayment = await _context.ChequeTechPayments.FindAsync(id);

            if (chequeTechPayment == null)
            {
                return NotFound();
            }

            return chequeTechPayment;
        }

        // PUT: api/ChequeTechPayments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChequeTechPayment(int id, ChequeTechPayment chequeTechPayment)
        {
            if (id != chequeTechPayment.IdCeque)
            {
                return BadRequest();
            }

            _context.Entry(chequeTechPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChequeTechPaymentExists(id))
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

        // POST: api/ChequeTechPayments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChequeTechPayment>> PostChequeTechPayment(ChequeTechPayment chequeTechPayment)
        {
            _context.ChequeTechPayments.Add(chequeTechPayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChequeTechPayment", new { id = chequeTechPayment.IdCeque }, chequeTechPayment);
        }

        // DELETE: api/ChequeTechPayments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChequeTechPayment>> DeleteChequeTechPayment(int id)
        {
            var chequeTechPayment = await _context.ChequeTechPayments.FindAsync(id);
            if (chequeTechPayment == null)
            {
                return NotFound();
            }

            _context.ChequeTechPayments.Remove(chequeTechPayment);
            await _context.SaveChangesAsync();

            return chequeTechPayment;
        }

        private bool ChequeTechPaymentExists(int id)
        {
            return _context.ChequeTechPayments.Any(e => e.IdCeque == id);
        }
    }
}
