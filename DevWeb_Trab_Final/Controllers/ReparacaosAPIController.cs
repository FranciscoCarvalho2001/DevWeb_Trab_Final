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
    public class ReparacaosAPIController : ControllerBase
    {
        private readonly DevWeb_Trab_FinalContext _context;

        public ReparacaosAPIController(DevWeb_Trab_FinalContext context)
        {
            _context = context;
        }

        // GET: api/ReparacaosAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reparacao>>> GetReparacao()
        {
            return await _context.Reparacao.ToListAsync();
        }

        // GET: api/ReparacaosAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reparacao>> GetReparacao(int id)
        {
            var reparacao = await _context.Reparacao.FindAsync(id);

            if (reparacao == null)
            {
                return NotFound();
            }

            return reparacao;
        }

        // PUT: api/ReparacaosAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReparacao(int id, Reparacao reparacao)
        {
            if (id != reparacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(reparacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReparacaoExists(id))
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

        // POST: api/ReparacaosAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reparacao>> PostReparacao(Reparacao reparacao)
        {
            _context.Reparacao.Add(reparacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReparacao", new { id = reparacao.Id }, reparacao);
        }

        // DELETE: api/ReparacaosAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReparacao(int id)
        {
            var reparacao = await _context.Reparacao.FindAsync(id);
            if (reparacao == null)
            {
                return NotFound();
            }

            _context.Reparacao.Remove(reparacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReparacaoExists(int id)
        {
            return _context.Reparacao.Any(e => e.Id == id);
        }
    }
}
