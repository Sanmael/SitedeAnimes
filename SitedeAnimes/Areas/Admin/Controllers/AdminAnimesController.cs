using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using SitedeAnimes.Context;
using SitedeAnimes.Models;

namespace SitedeAnimes.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminAnimesController : Controller
    {
        private readonly AppDbContext _context;

        public AdminAnimesController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: Admin/AdminAnimes
        //public async Task<IActionResult> Index()
        //{
        //    var appDbContext = _context.Animes.Include(a => a.Genero);
        //    return View(await appDbContext.ToListAsync());
        //}
        public async Task<IActionResult> Index(string filter, int pageindex = 1, string sort = "Nome")
        {
            var resultado = _context.Animes.Include(a => a.Genero).AsQueryable();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                resultado = resultado.Where(p => p.Nome.Contains(filter));
            }
            var model = await PagingList.CreateAsync(resultado, 5, pageindex, sort, "Nome");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };
            return View(model);

        }
        // GET: Admin/AdminAnimes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anime = await _context.Animes
                .Include(a => a.Genero)
                .FirstOrDefaultAsync(m => m.AnimeId == id);
            if (anime == null)
            {
                return NotFound();
            }

            return View(anime);
        }

        // GET: Admin/AdminAnimes/Create
        public IActionResult Create()
        {
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nome");
            return View();
        }

        // POST: Admin/AdminAnimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnimeId,Nome,NomeDoDiretor,NumeroDeEpisodios,NumeroDeTemporadas,AnoDeLancamento,Descricao,ImagemUrl,ImagemUrlPagina,IsAnimePreferido,Nota,SiteAssistirAnime,GeneroId")] Anime anime)
        {
            if (ModelState.IsValid)
            {
                _context.Add(anime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nome", anime.GeneroId);
            return View(anime);
        }

        // GET: Admin/AdminAnimes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anime = await _context.Animes.FindAsync(id);
            if (anime == null)
            {
                return NotFound();
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nome", anime.GeneroId);
            return View(anime);
        }

        // POST: Admin/AdminAnimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AnimeId,Nome,NomeDoDiretor,NumeroDeEpisodios,NumeroDeTemporadas,AnoDeLancamento,Descricao,ImagemUrl,ImagemUrlPagina,IsAnimePreferido,Nota,SiteAssistirAnime,GeneroId")] Anime anime)
        {
            if (id != anime.AnimeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(anime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimeExists(anime.AnimeId))
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
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nome", anime.GeneroId);
            return View(anime);
        }

        // GET: Admin/AdminAnimes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anime = await _context.Animes
                .Include(a => a.Genero)
                .FirstOrDefaultAsync(m => m.AnimeId == id);
            if (anime == null)
            {
                return NotFound();
            }

            return View(anime);
        }

        // POST: Admin/AdminAnimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var anime = await _context.Animes.FindAsync(id);
            _context.Animes.Remove(anime);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimeExists(int id)
        {
            return _context.Animes.Any(e => e.AnimeId == id);
        }
    }
}
