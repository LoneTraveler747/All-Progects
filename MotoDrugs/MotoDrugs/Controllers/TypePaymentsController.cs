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
    public class TypePaymentsController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public TypePaymentsController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/TypePayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypePayment>>> GetTypePayments()
        {
            return await _context.TypePayments.ToListAsync();
        }

        // GET: api/TypePayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypePayment>> GetTypePayment(int id)
        {
            var typePayment = await _context.TypePayments.FindAsync(id);

            if (typePayment == null)
            {
                return NotFound();
            }

            return typePayment;
        }

        // PUT: api/TypePayments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypePayment(int id, TypePayment typePayment)
        {
            if (id != typePayment.IdPayment)
            {
                return BadRequest();
            }

            _context.Entry(typePayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypePaymentExists(id))
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

        // POST: api/TypePayments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TypePayment>> PostTypePayment(TypePayment typePayment)
        {
            _context.TypePayments.Add(typePayment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypePayment", new { id = typePayment.IdPayment }, typePayment);
        }

        // DELETE: api/TypePayments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TypePayment>> DeleteTypePayment(int id)
        {
            var typePayment = await _context.TypePayments.FindAsync(id);
            if (typePayment == null)
            {
                return NotFound();
            }

            _context.TypePayments.Remove(typePayment);
            await _context.SaveChangesAsync();

            return typePayment;
        }

        private bool TypePaymentExists(int id)
        {
            return _context.TypePayments.Any(e => e.IdPayment == id);
        }
    }
}
