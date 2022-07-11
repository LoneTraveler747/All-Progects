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
    public class ChequeEquipmentsController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public ChequeEquipmentsController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/ChequeEquipments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChequeEquipment>>> GetChequeEquipments()
        {
            return await _context.ChequeEquipments.ToListAsync();
        }

        // GET: api/ChequeEquipments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChequeEquipment>> GetChequeEquipment(int id)
        {
            var chequeEquipment = await _context.ChequeEquipments.FindAsync(id);

            if (chequeEquipment == null)
            {
                return NotFound();
            }

            return chequeEquipment;
        }

        // PUT: api/ChequeEquipments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChequeEquipment(int id, ChequeEquipment chequeEquipment)
        {
            if (id != chequeEquipment.IdNumCheque)
            {
                return BadRequest();
            }

            _context.Entry(chequeEquipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChequeEquipmentExists(id))
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

        // POST: api/ChequeEquipments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChequeEquipment>> PostChequeEquipment(ChequeEquipment chequeEquipment)
        {
            _context.ChequeEquipments.Add(chequeEquipment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChequeEquipment", new { id = chequeEquipment.IdNumCheque }, chequeEquipment);
        }

        // DELETE: api/ChequeEquipments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChequeEquipment>> DeleteChequeEquipment(int id)
        {
            var chequeEquipment = await _context.ChequeEquipments.FindAsync(id);
            if (chequeEquipment == null)
            {
                return NotFound();
            }

            _context.ChequeEquipments.Remove(chequeEquipment);
            await _context.SaveChangesAsync();

            return chequeEquipment;
        }

        private bool ChequeEquipmentExists(int id)
        {
            return _context.ChequeEquipments.Any(e => e.IdNumCheque == id);
        }
    }
}
