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
    public class ClientMenController : ControllerBase
    {
        private readonly MotoDrugsContext _context;

        public ClientMenController(MotoDrugsContext context)
        {
            _context = context;
        }

        // GET: api/ClientMen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientMan>>> GetClientMen()
        {
            return await _context.ClientMen.ToListAsync();
        }

        // GET: api/ClientMen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientMan>> GetClientMan(int id)
        {
            var clientMan = await _context.ClientMen.FindAsync(id);

            if (clientMan == null)
            {
                return NotFound();
            }

            return clientMan;
        }

        // PUT: api/ClientMen/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientMan(int id, ClientMan clientMan)
        {
            if (id != clientMan.IdClient)
            {
                return BadRequest();
            }

            _context.Entry(clientMan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientManExists(id))
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

        // POST: api/ClientMen
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ClientMan>> PostClientMan(ClientMan clientMan)
        {
            _context.ClientMen.Add(clientMan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientMan", new { id = clientMan.IdClient }, clientMan);
        }

        // DELETE: api/ClientMen/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ClientMan>> DeleteClientMan(int id)
        {
            var clientMan = await _context.ClientMen.FindAsync(id);
            if (clientMan == null)
            {
                return NotFound();
            }

            _context.ClientMen.Remove(clientMan);
            await _context.SaveChangesAsync();

            return clientMan;
        }

        private bool ClientManExists(int id)
        {
            return _context.ClientMen.Any(e => e.IdClient == id);
        }
    }
}
