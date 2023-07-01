using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevWeb_Trab_Final.Data;
using DevWeb_Trab_Final.Models;
using DevWeb_Trab_Final.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace DevWeb_Trab_Final.Controllers
{
    [Authorize(Roles = "Administrador, Funcionario")]
    public class FuncionariosController : Controller
    {
        private readonly DevWeb_Trab_FinalContext _context;

        public FuncionariosController(DevWeb_Trab_FinalContext context)
        {
            _context = context;
        }

        // GET: Funcionarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Funcionarios.ToListAsync());
        }

        
        public async Task<IActionResult> Administrador()
        {
            var model = new AdministradorView();

            model.Clientes = await _context.Clientes.ToListAsync();
            model.Dispositivos = await _context.Dispositivos.Include(c => c.Cliente).Include(r => r.ListaReparacao).Include(f=>f.ListaFotografias).ToListAsync();
            model.Funcionarios = await _context.Funcionarios.ToListAsync();
            model.Reparacao = await _context.Reparacao.Include(d=>d.Dispositivo).Include(f=>f.Funcionarios).ToListAsync();

            return View(model);
        }

        // GET: Funcionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Funcionarios == null)
            {
                return NotFound();
            }

            var funcionarios = await _context.Funcionarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionarios == null)
            {
                return NotFound();
            }

            return View(funcionarios);
        }

        // GET: Funcionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Morada,CodPostal,Email,Telemovel,Especializacao")] Funcionarios funcionarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funcionarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionarios);
        }

        // GET: Funcionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Funcionarios == null)
            {
                return NotFound();
            }

            var funcionarios = await _context.Funcionarios.FindAsync(id);
            if (funcionarios == null)
            {
                return NotFound();
            }
            return View(funcionarios);
        }

        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Morada,CodPostal,Email,Telemovel,Especializacao")] Funcionarios funcionarios)
        {
            if (id != funcionarios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcionarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionariosExists(funcionarios.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Administrador", "Funcionarios");
            }
            return View(funcionarios);
        }

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Funcionarios == null)
            {
                return NotFound();
            }

            var funcionarios = await _context.Funcionarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionarios == null)
            {
                return NotFound();
            }

            return View(funcionarios);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Funcionarios == null)
            {
                return Problem("Entity set 'DevWeb_Trab_FinalContext.Funcionarios'  is null.");
            }
            var funcionarios = await _context.Funcionarios.FindAsync(id);
            if (funcionarios != null)
            {
                _context.Funcionarios.Remove(funcionarios);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Administrador", "Funcionarios");
        }

        private bool FuncionariosExists(int id)
        {
          return _context.Funcionarios.Any(e => e.Id == id);
        }
    }
}
