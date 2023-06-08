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

        /// <summary>
        /// este recurso vai proporcionar acesso aos dados dos recursos do servidor
        /// </summary>
        /// <param name="context"></param>
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DispositivosController(DevWeb_Trab_FinalContext context, IWebHostEnvironment webHostEnvironment) {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
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
                .Include(d => d.ListaFotografias)
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
        public async Task<IActionResult> Create([Bind("Id,Tipo,DataReg,Modelo,Foto,Estado,ClienteFK")] Dispositivos dispositivos, IFormFile imagemDispositivo) {

            // vars aux
            string nomeFoto = "";
            bool existeFoto = false;

            // ver se há condições para adicionar o dispositivo
            if (dispositivos.ClienteFK == 0) {
                //não foi escolhido o cliente
                ModelState.AddModelError("", "É preciso escolher o Cliente!");
            } else {
                // há cliente, agora confirmar se foi escolhida uma Imagem
                if (imagemDispositivo == null) {
                    // não se fez o upload da imagem
                    // imagem predefenida
                    dispositivos.ListaFotografias.Add(new Fotografias { NomeFoto = "noDispositivo.png" });
                } else {
                    // já há ficheiro, agora confirmar que é uma imagem
                    if (imagemDispositivo.ContentType != "image/jpeg" && imagemDispositivo.ContentType != "image/png") {
                        //o ficheiro carregado não é uma imagem, logo vai acontecer o mesmo quando não se fornece uma imagem
                        dispositivos.ListaFotografias.Add(new Fotografias { NomeFoto = "noDispositivo.png" });
                    } else {
                        // agora já há imagem
                        // obter nome da imagem
                        Guid g = Guid.NewGuid();
                        nomeFoto = g.ToString();
                        // obter extensão do ficheiro
                        string extensaoFoto = Path.GetExtension(imagemDispositivo.FileName).ToLower();
                        nomeFoto += extensaoFoto;

                        // guardar dados do ficheiro na BD
                        dispositivos.ListaFotografias.Add(new Fotografias { NomeFoto = nomeFoto });

                        // informar que há um ficheiro(imagem) para guardar no disco
                        existeFoto = true;
                    }
                } // imagemDispositivo == null
            } // dispositivos.ClienteFK == 0

            // se os dados recebido respeitam o modelo, o dados vão ser adicionados
            if (ModelState.IsValid) {

                try {
                    // adionar dados á BD
                    _context.Add(dispositivos);
                    // COMMIT da ação anterior
                    await _context.SaveChangesAsync();

                    // já foram guardados os dados do dispositivo na BD logo já posso guardar a imagem no disco do servidor
                    if (existeFoto) {
                        // determinar onde guardar a imagem
                        string nomeLocalizacaoImagem = _webHostEnvironment.WebRootPath;
                        nomeLocalizacaoImagem = Path.Combine(nomeLocalizacaoImagem, "imagens");
                        // determinar se existe pasta para guardar a imagem
                        if (!Directory.Exists(nomeLocalizacaoImagem)) {
                            Directory.CreateDirectory(nomeLocalizacaoImagem);
                        }

                        // informar o servidor do nome do ficheiro
                        string nomeFicheiro = Path.Combine(nomeLocalizacaoImagem, nomeFoto);
                        // guardar o ficheiro
                        using var stream = new FileStream(nomeFicheiro, FileMode.Create);
                        await imagemDispositivo.CopyToAsync(stream);
                    }
                    // devolver o controlo da app para a página do início
                    return RedirectToAction(nameof(Index));
                } catch (Exception) {
                    ModelState.AddModelError("", "Ocurreu um erro com a adição dos dados do seu Dispositivo");
                    // trow;
                }
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
