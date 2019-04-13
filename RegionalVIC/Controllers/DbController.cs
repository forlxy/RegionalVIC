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
    public class DbController : Controller
    {
        private readonly regionalVICContext _context;

        public DbController(regionalVICContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Lgamas.ToListAsync());
        }

        //  Get LGAMAS by status. e.g. "R" - Region
        public async Task<IActionResult> GetRegionLGA(char sts)
        {
            //  So far, cannot get result with this statement. lgamas.Count() is 0.
            var lgamas = await _context.Lgamas
                .FirstOrDefaultAsync(e => e.Status.Contains(sts));
                //.Where(e => e.State.Contains(sts));
                
            if (lgamas == null)
            {
                return NotFound();
            }

            return View(lgamas);
        }

    }
}
