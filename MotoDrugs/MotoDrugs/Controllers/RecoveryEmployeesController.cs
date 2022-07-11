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
    public class RecoveryEmployeesController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public RecoveryEmployeesController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/RecoveryEmployees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecoveryEmployee>>> GetRecoveryEmployees()
        {
            return await _context.RecoveryEmployees.ToListAsync();
        }

        // GET: api/RecoveryEmployees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecoveryEmployee>> GetRecoveryEmployee(int id)
        {
            var recoveryEmployee = await _context.RecoveryEmployees.FindAsync(id);

            if (recoveryEmployee == null)
            {
                return NotFound();
            }

            return recoveryEmployee;
        }

        // PUT: api/RecoveryEmployees/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecoveryEmployee(int id, RecoveryEmployee recoveryEmployee)
        {
            if (id != recoveryEmployee.IdRecoveryEmployee)
            {
                return BadRequest();
            }

            _context.Entry(recoveryEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecoveryEmployeeExists(id))
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

        // POST: api/RecoveryEmployees
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RecoveryEmployee>> PostRecoveryEmployee(RecoveryEmployee recoveryEmployee)
        {
            _context.RecoveryEmployees.Add(recoveryEmployee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecoveryEmployee", new { id = recoveryEmployee.IdRecoveryEmployee }, recoveryEmployee);
        }

        // DELETE: api/RecoveryEmployees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RecoveryEmployee>> DeleteRecoveryEmployee(int id)
        {
            var recoveryEmployee = await _context.RecoveryEmployees.FindAsync(id);
            if (recoveryEmployee == null)
            {
                return NotFound();
            }

            _context.RecoveryEmployees.Remove(recoveryEmployee);
            await _context.SaveChangesAsync();

            return recoveryEmployee;
        }

        private bool RecoveryEmployeeExists(int id)
        {
            return _context.RecoveryEmployees.Any(e => e.IdRecoveryEmployee == id);
        }
    }
}
