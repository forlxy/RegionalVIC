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

        //  Get the list of Year and Quarter in RTRTBL By LGA_code with conditions. e.g. for 10 years records from 2009, year >= 2009
        [HttpPost]
        public Object GetRtrYrQtr(int yr)
        {
            var rtrtbl = _context.Rtrtbl.Where(m => m.Yr >= yr).Select(m => new { m.Yr, m.Quarter }).Distinct().OrderBy(m => m.Yr).ThenBy(m => m.Quarter).ToList();

            if (rtrtbl == null)
            {
                return NotFound();
            }

            return rtrtbl;
        }

        //  Get the list of COBTBL By LGA_code with join table & conditions
        [HttpPost]
        public Object GetPpltblByLGA(string lga_code, char sts, int yr)
        {
            var ppltbl = (from lga in _context.Lgamas
                          join ppl in _context.Ppltbl on lga.LgaCode equals ppl.LgaCode
                          where lga.LgaCode.Contains(lga_code) && lga.Status.Contains(sts) && ppl.Yr == yr
                          select new
                          {
                              Lga = ppl.LgaCode,
                              Yrs = ppl.Yr,
                              Pop = ppl.Popul,
                              Den = ppl.Density
                          }).Take(1).ToList();

            if (ppltbl == null)
            {
                return NotFound();
            }

            return ppltbl;
        }

        //  Get the list of COBTBL By LGA_code with join table & conditions
        [HttpPost]
        public Object GetCobtblByLGA(string lga_code, char sts, int yr)
        {
            var cobtbl = (from lga in _context.Lgamas
                          join cob in _context.Cobtbl on lga.LgaCode equals cob.LgaCode
                          join cbm in _context.Cobmas on cob.CobCode equals cbm.Seq
                          where lga.LgaCode.Contains(lga_code) && lga.Status.Contains(sts) && cob.Yr == yr
                          select new
                          {
                              Lga = cob.LgaCode,
                              Yrs = cob.Yr,
                              Eth = cbm.Cob,
                              Pop = cob.Ppl,
                              Pct = cob.Percnt,
                              Den = cob.Ttl_ppl
                          }).ToList();

            if (cobtbl == null)
            {
                return NotFound();
            }

            return cobtbl;
        }

        //  Get the list of CMMTBL By LGA_code with join table & conditions
        [HttpPost]
        public Object GetCmmtblByLGA(string lga_code, char sts, int yr)
        {
            var cmmtbl = (from lga in _context.Lgamas
                          join cmm in _context.Cobtbl on lga.LgaCode equals cmm.LgaCode
                          join cbm in _context.Cobmas on cmm.CobCode equals cbm.Seq
                          where lga.LgaCode.Contains(lga_code) && lga.Status.Contains(sts) && cmm.Yr == yr
                          select new
                          {
                              Lga = cmm.LgaCode,
                              Yrs = cmm.Yr,
                              Eth = cbm.Cob,
                              Pop = cmm.Ppl,
                              Pct = cmm.Percnt,
                              Den = cmm.Ttl_ppl
                          }).ToList();

            if (cmmtbl == null)
            {
                return NotFound();
            }

            return cmmtbl;
        }

        //  Get the list of LGGTBL By LGA_code with join table, conditions & ordering
        [HttpPost]
        public Object GetLggtblByLGA(string lga_code, char sts, int yr)
        {
            var lggtbl = (from lga in _context.Lgamas
                          join lgg in _context.Lggtbl on lga.LgaCode equals lgg.LgaCode
                          join lgm in _context.Lggmas on lgg.LangCode equals lgm.Seq
                          where lga.LgaCode.Contains(lga_code) && lga.Status.Contains(sts) && lgg.Yr == yr
                          orderby lgg.Percnt descending
                          select new
                          {
                              Lga = lgg.LgaCode,
                              Yrs = lgg.Yr,
                              Eth = lgm.Lang,
                              Pop = lgg.Ppl,
                              Pct = lgg.Percnt,
                              Den = lgg.Ttl_ppl
                          }).ToList();

            if (lggtbl == null)
            {
                return NotFound();
            }

            return lggtbl;
        }

        //public async Task<IActionResult> GetRegionLGA(char sts)
        //{
        //    var lgamas = await _context.Lgamas
        //        .Where(e => e.Status.Contains(sts)).ToListAsync();

        //    if (lgamas == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(lgamas);
        //}

    }
}
