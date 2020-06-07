using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectAniversarioWeb.Data;
using ProjectAniversarioWeb.Models;

namespace ProjectAniversarioWeb.Controllers
{
    public class AniversariantesController : Controller
    {
        private readonly ProjectAniversarioWebContext _context;

        public AniversariantesController(ProjectAniversarioWebContext context)
        {
            _context = context;
        }

        // GET: Aniversariantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aniversariante.ToListAsync());
        }

        // GET: Aniversariantes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aniversariante = await _context.Aniversariante
                .FirstOrDefaultAsync(m => m.primeiroNome == id);
            if (aniversariante == null)
            {
                return NotFound();
            }

            return View(aniversariante);
        }

        // GET: Aniversariantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aniversariantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("primeiroNome,segundoNome,dataAniversario")] Aniversariante aniversariante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aniversariante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aniversariante);
        }

        // GET: Aniversariantes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aniversariante = await _context.Aniversariante.FindAsync(id);
            if (aniversariante == null)
            {
                return NotFound();
            }
            return View(aniversariante);
        }

        // POST: Aniversariantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("primeiroNome,segundoNome,dataAniversario")] Aniversariante aniversariante)
        {
            if (id != aniversariante.primeiroNome)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aniversariante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AniversarianteExists(aniversariante.primeiroNome))
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
            return View(aniversariante);
        }

        // GET: Aniversariantes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aniversariante = await _context.Aniversariante
                .FirstOrDefaultAsync(m => m.primeiroNome == id);
            if (aniversariante == null)
            {
                return NotFound();
            }

            return View(aniversariante);
        }

        // POST: Aniversariantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var aniversariante = await _context.Aniversariante.FindAsync(id);
            _context.Aniversariante.Remove(aniversariante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AniversarianteExists(string id)
        {
            return _context.Aniversariante.Any(e => e.primeiroNome == id);
        }
    }
}
