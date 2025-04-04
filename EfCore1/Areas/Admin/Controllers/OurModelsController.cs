using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCore.DataAccess.Data;
using EFCore.Models.Models;

namespace EfCore1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurModelsController : Controller
    {
        private readonly AppDbContext _context;

        public OurModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OurModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.OurMM.ToListAsync());

        }

        // GET: OurModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourModel = await _context.OurMM
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourModel == null)
            {
                return NotFound();
            }

            return View(ourModel);
        }

        // GET: OurModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OurModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,AuthorName")] OurModel ourModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ourModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ourModel);
        }

        // GET: OurModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourModel = await _context.OurMM.FindAsync(id);
            if (ourModel == null)
            {
                return NotFound();
            }
            return View(ourModel);
        }

        // POST: OurModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Title,AuthorName")] OurModel ourModel)
        {
            if (id != ourModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ourModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OurModelExists(ourModel.Id))
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
            return View(ourModel);
        }

        // GET: OurModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ourModel = await _context.OurMM
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ourModel == null)
            {
                return NotFound();
            }

            return View(ourModel);
        }

        // POST: OurModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ourModel = await _context.OurMM.FindAsync(id);
            if (ourModel != null)
            {
                _context.OurMM.Remove(ourModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OurModelExists(string id)
        {
            return _context.OurMM.Any(e => e.Id == id);
        }
    }
}
