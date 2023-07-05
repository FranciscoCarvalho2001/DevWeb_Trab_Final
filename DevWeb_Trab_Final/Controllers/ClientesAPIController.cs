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
using DevWeb_Trab_Final.Areas.Identity.Pages.Account;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

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

        // POST: api/ClientesAPI/login
        [HttpPost("login")]
        public async Task<IActionResult> Login(Login login) {

            // check para ver se o user existe na DB
            var user = await _userManager.FindByEmailAsync(login.Email);
            // se falhar...
            if (user == null) {
                // retorna Erro
                return BadRequest("Email ou Password inválido");
            }

            // tenta fazer sign in com as credenciais submetidas e retorna um objeto com o resultado da operação
            var result = await _signInManager.CheckPasswordSignInAsync(user, login.Password, lockoutOnFailure: false);
            // se falhar...
            if (!result.Succeeded) {
                // retorna Erro
                return BadRequest("Credenciais inválidas");
            }

            // obtem o ID do Cliente associado ao Email
            var cliente = await _context.Clientes.FirstOrDefaultAsync(i => i.UserId == user.Id);

            // retorna o ID do cliente
            return Ok(new { ClienteId = cliente.Id });
        }

        // POST: api/ClientesAPI/logout
        [HttpPost("logout")]
        public async Task<IActionResult> Logout() {

            // faz sign out do user logado na aplicação
            await _signInManager.SignOutAsync();
            // retorna uma mensagem
            return Ok(new { Message = "Logout feito!" });
        }

        // -------------------------------------------------------------------------------------------------------------------

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
            // cria um User, com as devidas informações fornecidas do Cliente
            var user = new DevWeb_Trab_Final_User {
                UserName = clientes.Email,
                Email = clientes.Email,
                NomeUtilizador = clientes.Nome,
                PhoneNumber = clientes.Telemovel,
                EmailConfirmed = true,
                DataRegisto = DateTime.Now
            };

            // obtem a password do User fornecida pelo o URL recebido
            string password = Request.Query["password"];

            // Cria o User na DB
            var result = await _userManager.CreateAsync(user, password);

            // se o User foi criado com sucesso...
            if(result.Succeeded) {
                // adiciona ao role "Cliente" da DB
                await _userManager.AddToRoleAsync(user, "Cliente");
                // ligação entre a DB do negócio e a DB de autenticação
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
                
                // retorna um objeto com o resultado da operação
                return CreatedAtAction("GetClientes", new { id = clientes.Id }, clientes);

            } else {
                // se não, retorna Erro
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
