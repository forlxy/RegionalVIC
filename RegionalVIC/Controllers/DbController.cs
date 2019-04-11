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

        //  Get LGAMAS by status. e.g. "R" - Region
        private void getLGAMAS(char sts)
        {
            var lgamas = _context.Lgamas.Where(e => e.State.Contains(sts));

        }
    }
}
