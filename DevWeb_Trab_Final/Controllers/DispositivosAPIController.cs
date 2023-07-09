using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevWeb_Trab_Final.Data;
using DevWeb_Trab_Final.Models;

namespace DevWeb_Trab_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispositivosAPIController : ControllerBase
    {
        private readonly DevWeb_Trab_FinalContext _context;

        public DispositivosAPIController(DevWeb_Trab_FinalContext context)
        {
            _context = context;
        }

        // GET: api/DispositivosAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dispositivos>>> GetDispositivos()
        {
            return await _context.Dispositivos.ToListAsync();
        }

        // GET: api/DispositivosAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dispositivos>> GetDispositivos(int id)
        {
            var dispositivos = await _context.Dispositivos.FindAsync(id);

            if (dispositivos == null)
            {
                return NotFound();
            }

            return dispositivos;
        }

        // PUT: api/DispositivosAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDispositivos(int id, Dispositivos dispositivos)
        {
            if (id != dispositivos.Id)
            {
                return BadRequest();
            }

            _context.Entry(dispositivos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DispositivosExists(id))
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

        // POST: api/DispositivosAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dispositivos>> PostDispositivos(Dispositivos dispositivos)
        {
            _context.Dispositivos.Add(dispositivos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDispositivos", new { id = dispositivos.Id }, dispositivos);
        }

        // DELETE: api/DispositivosAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDispositivos(int id)
        {
            var dispositivos = await _context.Dispositivos.FindAsync(id);
            if (dispositivos == null)
            {
                return NotFound();
            }

            _context.Dispositivos.Remove(dispositivos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DispositivosExists(int id)
        {
            return _context.Dispositivos.Any(e => e.Id == id);
        }
    }
}
