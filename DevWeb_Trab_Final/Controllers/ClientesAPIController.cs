using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevWeb_Trab_Final.Data;
using DevWeb_Trab_Final.Models;
using Microsoft.AspNetCore.Identity;

namespace DevWeb_Trab_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesAPIController : ControllerBase
    {
        private readonly DevWeb_Trab_FinalContext _context;
        private readonly UserManager<DevWeb_Trab_Final_User> _userManager;
        private readonly SignInManager<DevWeb_Trab_Final_User> _signInManager;

        public ClientesAPIController(DevWeb_Trab_FinalContext context,
            UserManager<DevWeb_Trab_Final_User> userManager,
            SignInManager<DevWeb_Trab_Final_User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        // GET: api/ClientesAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clientes>>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        // GET: api/ClientesAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clientes>> GetClientes(int id)
        {
            var clientes = await _context.Clientes.FindAsync(id);

            if (clientes == null)
            {
                return NotFound();
            }

            return clientes;
        }

        // PUT: api/ClientesAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientes(int id, Clientes clientes)
        {
            if (id != clientes.Id)
            {
                return BadRequest();
            }

            _context.Entry(clientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientesExists(id))
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

        // POST: api/ClientesAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("create")]
        public async Task<ActionResult<Clientes>> PostClientes(Clientes clientes)
        {
            var user = new DevWeb_Trab_Final_User {
                UserName = clientes.Email,
                Email = clientes.Email,
                NomeUtilizador = clientes.Nome,
                EmailConfirmed = true,
                DataRegisto = DateTime.Now
            };

            string password = Request.Query["password"];

            var result = await _userManager.CreateAsync(user, password);

            if(result.Succeeded) {
                await _userManager.AddToRoleAsync(user, "Cliente");

                clientes.UserId = user.Id;

                try {
                    //adiconar os dados á DB
                    _context.Clientes.Add(clientes);
                    await _context.SaveChangesAsync();
                } catch (Exception) {
                    //remover os dados á DB
                    _context.Remove(clientes);
                    await _context.SaveChangesAsync();
                }
                
                return CreatedAtAction("GetClientes", new { id = clientes.Id }, clientes);

            } else {

                return BadRequest(result.Errors);
            }
        }

        // DELETE: api/ClientesAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientes(int id)
        {
            var clientes = await _context.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(clientes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientesExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
