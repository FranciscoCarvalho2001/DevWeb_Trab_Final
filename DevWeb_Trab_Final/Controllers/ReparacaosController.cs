using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevWeb_Trab_Final.Data;
using DevWeb_Trab_Final.Models;

namespace DevWeb_Trab_Final.Controllers
{
    public class ReparacaosController : Controller
    {
        private readonly DevWeb_Trab_FinalContext _context;

        public ReparacaosController(DevWeb_Trab_FinalContext context)
        {
            _context = context;
        }

        // GET: Reparacaos
        public async Task<IActionResult> Index()
        {
            var devWeb_Trab_FinalContext = _context.Reparacao.Include(r => r.Dispositivo).Include(f => f.Funcionarios).Include(c => c.Dispositivo.Cliente);
            return View(await devWeb_Trab_FinalContext.ToListAsync());
        }

        // GET: Reparacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reparacao == null)
            {
                return NotFound();
            }

            var reparacao = await _context.Reparacao
                .Include(r => r.Dispositivo)
                .Include(r => r.Funcionarios)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reparacao == null)
            {
                return NotFound();
            }

            return View(reparacao);
        }

        // GET: Reparacaos/Create
        public IActionResult Create()
        {
            ViewData["DispositivoFK"] = new SelectList(_context.Dispositivos, "Id", "Tipo");
            ViewData["FuncionariosFK"] = new SelectList(_context.Funcionarios, "Id", "Nome");
            return View();
        }

        // POST: Reparacaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataInicio,DataFim,Custo,CustoAux,Observacao,DispositivoFK,FuncionariosFK")] Reparacao reparacao)
        {
            if (!string.IsNullOrEmpty(reparacao.CustoAux)) {
                reparacao.Custo = Convert.ToDecimal(reparacao.CustoAux.Replace('.', ','));
            }
            if (ModelState.IsValid)
            {
                _context.Add(reparacao);
                await _context.SaveChangesAsync();
                return RedirectToAction("Administrador", "Funcionarios");
            }

            ViewData["DispositivoFK"] = new SelectList(_context.Dispositivos, "Id", "Tipo", reparacao.DispositivoFK);
            ViewData["FuncionariosFK"] = new SelectList(_context.Funcionarios, "Id", "Nome", reparacao.FuncionariosFK);
            return View(reparacao);
        }

        // GET: Reparacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var reparacao = await _context.Reparacao.FindAsync(id);
            
                reparacao.CustoAux = Convert.ToString(reparacao.Custo);
            
            if (id == null || _context.Reparacao == null)
            {
                return NotFound();
            }

            if (reparacao == null)
            {
                return NotFound();
            }
            ViewData["DispositivoFK"] = new SelectList(_context.Dispositivos, "Id", "Tipo", reparacao.DispositivoFK);
            ViewData["FuncionariosFK"] = new SelectList(_context.Funcionarios, "Id", "Nome", reparacao.FuncionariosFK);
            return View(reparacao);
        }

        // POST: Reparacaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataInicio,DataFim,Custo,CustoAux,Observacao,DispositivoFK,FuncionariosFK")] Reparacao reparacao)
        {
            if (id != reparacao.Id)
            {
                return NotFound();
            }
            if (!string.IsNullOrEmpty(reparacao.CustoAux))
            {
                reparacao.Custo = Convert.ToDecimal(reparacao.CustoAux.Replace('.', ','));
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reparacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReparacaoExists(reparacao.Id))
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
            ViewData["DispositivoFK"] = new SelectList(_context.Dispositivos, "Id", "Tipo", reparacao.DispositivoFK);
            ViewData["FuncionariosFK"] = new SelectList(_context.Funcionarios, "Id", "Nome", reparacao.FuncionariosFK);
            return View(reparacao);
        }

        // GET: Reparacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reparacao == null)
            {
                return NotFound();
            }

            var reparacao = await _context.Reparacao
                .Include(r => r.Dispositivo)
                .Include(r => r.Funcionarios)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reparacao == null)
            {
                return NotFound();
            }

            return View(reparacao);
        }

        // POST: Reparacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reparacao == null)
            {
                return Problem("Entity set 'DevWeb_Trab_FinalContext.Reparacao'  is null.");
            }
            var reparacao = await _context.Reparacao.FindAsync(id);
            if (reparacao != null)
            {
                _context.Reparacao.Remove(reparacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Administrador", "Funcionarios");
        }

        private bool ReparacaoExists(int id)
        {
          return _context.Reparacao.Any(e => e.Id == id);
        }
    }
}
