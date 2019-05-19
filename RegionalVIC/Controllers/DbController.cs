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
        private readonly RegionalVICContext _context;

        public DbController(RegionalVICContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Lgamas.ToListAsync());
        }

        //  Get LGAMAS by status. e.g. "R" - Region Test
        [HttpPost]
        public Object GetRegionLGA(char sts)
        {
            var lgamas = _context.Lgamas
                .Where(e => e.Status.Contains(sts)).ToList();

            if (lgamas == null)
            {
                return NotFound();
            }

            return lgamas;
        }
        

    }
}
