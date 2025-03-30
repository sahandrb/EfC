using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFCore.Models;
using EFCore.DataAccess.Data;


namespace EfCore1.Controllers
{
    public class MelissaModelsController : Controller
    {
        private readonly AppDbContext _context;

        public MelissaModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MelissaModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.MmModel.ToListAsync());
        }

        // GET: MelissaModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melissaModel = await _context.MmModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (melissaModel == null)
            {
                return NotFound();
            }

            return View(melissaModel);
        }

        // GET: MelissaModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MelissaModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,College,Age")] MelissaModel melissaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(melissaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(melissaModel);
        }

        // GET: MelissaModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melissaModel = await _context.MmModel.FindAsync(id);
            if (melissaModel == null)
            {
                return NotFound();
            }
            return View(melissaModel);
        }

        // POST: MelissaModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,College,Age")] MelissaModel melissaModel)
        {
            if (id != melissaModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(melissaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MelissaModelExists(melissaModel.Id))
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
            return View(melissaModel);
        }

        // GET: MelissaModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melissaModel = await _context.MmModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (melissaModel == null)
            {
                return NotFound();
            }

            return View(melissaModel);
        }

        // POST: MelissaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var melissaModel = await _context.MmModel.FindAsync(id);
            if (melissaModel != null)
            {
                _context.MmModel.Remove(melissaModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MelissaModelExists(int id)
        {
            return _context.MmModel.Any(e => e.Id == id);
        }
    }
}
