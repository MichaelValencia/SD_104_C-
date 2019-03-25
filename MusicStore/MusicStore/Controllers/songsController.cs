using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace MusicStore.Controllers
{
    public class songsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _env;

        public songsController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: songs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Songs.ToListAsync());
        }

        // GET: songs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songs = await _context.Songs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (songs == null)
            {
                return NotFound();
            }

            return View(songs);
        }

        // GET: songs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: songs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Artist,Album,ReleaseDate,ImagePath,Genre,Price,IsActive,IsFeatured")] songs songs, IFormFile File)
        {
            if (File != null)
            {
                var fileName = Path.GetFileName(File.FileName);
                var path = _env.WebRootPath + "\\uploads\\albums\\" + fileName;

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await File.CopyToAsync(stream);
                }
                songs.ImagePath = "uploads/albums/" + fileName;

            }
            if (ModelState.IsValid)
            {
                _context.Add(songs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(songs);
        }

        // GET: songs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songs = await _context.Songs.FindAsync(id);
            if (songs == null)
            {
                return NotFound();
            }
            return View(songs);
        }

        // POST: songs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Artist,Album,ReleaseDate,ImagePath,Genre,Price,IsActive,IsFeatured")] songs songs, IFormFile file)
        {
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = _env.WebRootPath + "\\uploads\\albums\\" + fileName;

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                songs.ImagePath = "uploads/albums/" + fileName;
            }
            if (id != songs.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(songs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!songsExists(songs.ID))
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
            return View(songs);
        }

        // GET: songs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songs = await _context.Songs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (songs == null)
            {
                return NotFound();
            }

            return View(songs);
        }

        // POST: songs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var songs = await _context.Songs.FindAsync(id);
            _context.Songs.Remove(songs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool songsExists(int id)
        {
            return _context.Songs.Any(e => e.ID == id);
        }
    }
}
