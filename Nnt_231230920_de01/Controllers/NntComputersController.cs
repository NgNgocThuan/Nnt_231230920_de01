using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nnt_231230920_de01.Models;

namespace Nnt_231230920_de01.Controllers
{
    public class NntComputersController : Controller
    {
        private readonly NguyenNgocThuan231230920De01Context _context;

        public NntComputersController(NguyenNgocThuan231230920De01Context context)
        {
            _context = context;
        }

        // GET: NntComputers
        public async Task<IActionResult> NntIndex()
        {
            return View(await _context.NntComputers.ToListAsync());
        }

        // GET: NntComputers/Details/5
        public async Task<IActionResult> NntDetails(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nntComputer = await _context.NntComputers
                .FirstOrDefaultAsync(m => m.NntComId == id);
            if (nntComputer == null)
            {
                return NotFound();
            }

            return View(nntComputer);
        }

        // GET: NntComputers/Create
        public IActionResult NntCreate()
        {
            return View();
        }

        // POST: NntComputers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NntCreate([Bind("NntComId,NntComName,NntComPrice,NntComImage,NntComStatus")] NntComputer nntComputer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nntComputer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NntIndex));
            }
            return View(nntComputer);
        }

        // GET: NntComputers/Edit/5
        public async Task<IActionResult> NntEdit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nntComputer = await _context.NntComputers.FindAsync(id);
            if (nntComputer == null)
            {
                return NotFound();
            }
            return View(nntComputer);
        }

        // POST: NntComputers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NntEdit(string id, [Bind("NntComId,NntComName,NntComPrice,NntComImage,NntComStatus")] NntComputer nntComputer)
        {
            if (id != nntComputer.NntComId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nntComputer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NntComputerExists(nntComputer.NntComId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(NntIndex));
            }
            return View(nntComputer);
        }

        // GET: NntComputers/Delete/5
        public async Task<IActionResult> NntDelete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nntComputer = await _context.NntComputers
                .FirstOrDefaultAsync(m => m.NntComId == id);
            if (nntComputer == null)
            {
                return NotFound();
            }

            return View(nntComputer);
        }

        // POST: NntComputers/Delete/5
        [HttpPost, ActionName("NntDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nntComputer = await _context.NntComputers.FindAsync(id);
            if (nntComputer != null)
            {
                _context.NntComputers.Remove(nntComputer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NntIndex));
        }

        private bool NntComputerExists(string id)
        {
            return _context.NntComputers.Any(e => e.NntComId == id);
        }
    }
}
