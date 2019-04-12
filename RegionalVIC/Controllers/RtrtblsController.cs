using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegionalVIC.Models.DB;

namespace RegionalVIC.Controllers
{
    public class RtrtblsController : Controller
    {
        private readonly regionalVICContext _context;

        public RtrtblsController(regionalVICContext context)
        {
            _context = context;

            //  Testing DbController
            DbController DbCtrl = new DbController(_context);
            DbCtrl.getLGAMAS("R".ToString()[0]);
        }

        // GET: Rtrtbls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rtrtbl.ToListAsync());
        }

        // GET: Rtrtbls/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rtrtbl = await _context.Rtrtbl
                .FirstOrDefaultAsync(m => m.Seq == id);
            if (rtrtbl == null)
            {
                return NotFound();
            }

            return View(rtrtbl);
        }

        // GET: Rtrtbls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rtrtbls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Seq,Yr,Mth,Quarter,Region,LgaCode,Typ,NoOfBedrm,Count,Median")] Rtrtbl rtrtbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rtrtbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rtrtbl);
        }

        // GET: Rtrtbls/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rtrtbl = await _context.Rtrtbl.FindAsync(id);
            if (rtrtbl == null)
            {
                return NotFound();
            }
            return View(rtrtbl);
        }

        // POST: Rtrtbls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Seq,Yr,Mth,Quarter,Region,LgaCode,Typ,NoOfBedrm,Count,Median")] Rtrtbl rtrtbl)
        {
            if (id != rtrtbl.Seq)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rtrtbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RtrtblExists(rtrtbl.Seq))
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
            return View(rtrtbl);
        }

        // GET: Rtrtbls/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rtrtbl = await _context.Rtrtbl
                .FirstOrDefaultAsync(m => m.Seq == id);
            if (rtrtbl == null)
            {
                return NotFound();
            }

            return View(rtrtbl);
        }

        // POST: Rtrtbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var rtrtbl = await _context.Rtrtbl.FindAsync(id);
            _context.Rtrtbl.Remove(rtrtbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RtrtblExists(long id)
        {
            return _context.Rtrtbl.Any(e => e.Seq == id);
        }
    }
}
