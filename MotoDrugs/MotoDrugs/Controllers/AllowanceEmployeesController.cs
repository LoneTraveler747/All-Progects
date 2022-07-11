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
    public class AllowanceEmployeesController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public AllowanceEmployeesController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/AllowanceEmployees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AllowanceEmployee>>> GetAllowanceEmployees()
        {
            return await _context.AllowanceEmployees.ToListAsync();
        }

        // GET: api/AllowanceEmployees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AllowanceEmployee>> GetAllowanceEmployee(int id)
        {
            var allowanceEmployee = await _context.AllowanceEmployees.FindAsync(id);

            if (allowanceEmployee == null)
            {
                return NotFound();
            }

            return allowanceEmployee;
        }

        // PUT: api/AllowanceEmployees/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAllowanceEmployee(int id, AllowanceEmployee allowanceEmployee)
        {
            if (id != allowanceEmployee.IdAllowanceEmployee)
            {
                return BadRequest();
            }

            _context.Entry(allowanceEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllowanceEmployeeExists(id))
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

        // POST: api/AllowanceEmployees
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AllowanceEmployee>> PostAllowanceEmployee(AllowanceEmployee allowanceEmployee)
        {
            _context.AllowanceEmployees.Add(allowanceEmployee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAllowanceEmployee", new { id = allowanceEmployee.IdAllowanceEmployee }, allowanceEmployee);
        }

        // DELETE: api/AllowanceEmployees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AllowanceEmployee>> DeleteAllowanceEmployee(int id)
        {
            var allowanceEmployee = await _context.AllowanceEmployees.FindAsync(id);
            if (allowanceEmployee == null)
            {
                return NotFound();
            }

            _context.AllowanceEmployees.Remove(allowanceEmployee);
            await _context.SaveChangesAsync();

            return allowanceEmployee;
        }

        private bool AllowanceEmployeeExists(int id)
        {
            return _context.AllowanceEmployees.Any(e => e.IdAllowanceEmployee == id);
        }
    }
}
