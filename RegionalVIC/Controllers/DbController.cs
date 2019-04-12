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
        public void getLGAMAS(char sts)
        {
            //  So far, cannot get result with this statement. lgamas.Count() is 0.
            var lgamas = _context.Lgamas.Where(e => e.State.Contains(sts));
            var myLgaList = new List<string>();

            for (int i = 0; i < lgamas.Count(); i++)
            {
                // myLgaList.Add(lgamas.);
            }
            var myLgaArray = myLgaList.ToArray();

        }
    }
}
