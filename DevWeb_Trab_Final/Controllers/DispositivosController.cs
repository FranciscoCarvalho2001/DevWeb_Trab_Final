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
    public class DispositivosController : Controller
    {
        private readonly DevWeb_Trab_FinalContext _context;

        public DispositivosController(DevWeb_Trab_FinalContext context)
        {
            _context = context;
        }

        // GET: Dispositivos
        public async Task<IActionResult> Index()
        {
            var devWeb_Trab_FinalContext = _context.Dispositivos.Include(d => d.Cliente);
            return View(await devWeb_Trab_FinalContext.ToListAsync());
        }

        // GET: Dispositivos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Dispositivos == null)
            {
                return NotFound();
            }

            var dispositivos = await _context.Dispositivos
                .Include(d => d.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dispositivos == null)
            {
                return NotFound();
            }

            return View(dispositivos);
        }

        // GET: Dispositivos/Create
        public IActionResult Create()
        {
            ViewData["ClienteFK"] = new SelectList(_context.Clientes, "Id", "Email");
            return View();
        }

        // POST: Dispositivos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,DataReg,Modelo,Foto,Estado,ClienteFK")] Dispositivos dispositivos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dispositivos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteFK"] = new SelectList(_context.Clientes, "Id", "Email", dispositivos.ClienteFK);
            return View(dispositivos);
        }

        // GET: Dispositivos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dispositivos == null)
            {
                return NotFound();
            }

            var dispositivos = await _context.Dispositivos.FindAsync(id);
            if (dispositivos == null)
            {
                return NotFound();
            }
            ViewData["ClienteFK"] = new SelectList(_context.Clientes, "Id", "Email", dispositivos.ClienteFK);
            return View(dispositivos);
        }

        // POST: Dispositivos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,DataReg,Modelo,Foto,Estado,ClienteFK")] Dispositivos dispositivos)
        {
            if (id != dispositivos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dispositivos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DispositivosExists(dispositivos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteFK"] = new SelectList(_context.Clientes, "Id", "Email", dispositivos.ClienteFK);
            return View(dispositivos);
        }

        // GET: Dispositivos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dispositivos == null)
            {
                return NotFound();
            }

            var dispositivos = await _context.Dispositivos
                .Include(d => d.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dispositivos == null)
            {
                return NotFound();
            }

            return View(dispositivos);
        }

        // POST: Dispositivos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dispositivos == null)
            {
                return Problem("Entity set 'DevWeb_Trab_FinalContext.Dispositivos'  is null.");
            }
            var dispositivos = await _context.Dispositivos.FindAsync(id);
            if (dispositivos != null)
            {
                _context.Dispositivos.Remove(dispositivos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DispositivosExists(int id)
        {
          return _context.Dispositivos.Any(e => e.Id == id);
        }
    }
}
