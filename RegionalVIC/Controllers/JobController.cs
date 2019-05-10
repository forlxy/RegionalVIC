using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegionalVIC.Models;
using RegionalVIC.Models.DB;

namespace RegionalVIC.Controllers
{
    public class JobController : Controller
    {
        private RegionalVICContext _context;
        public JobController(RegionalVICContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public string getAllIndustry()
        {
            var list = _context.Idsmas.ToList();

            List<string> result = new List<string>();
            foreach (var i in list)
            {
                result.Add(i.IdsName);
            }


            var json = JsonConvert.SerializeObject(result);
            return json;

        }



        [HttpPost]
        public string getBarchartData(string[] industries, string[] regions, string option)
        {

            //join t in _context.Poetbl on r.IdsCode equals t.IdsCode

            if (option.Contains("0")) // Number of business
            {
                var list = (from r in _context.Idsmas
                            join l in _context.Nbitbl on r.IdsCode equals l.IdsCode
                            join t in _context.Lgamas on l.LgaCode equals t.LgaCode
                            where industries.Contains(r.IdsName) && regions.Contains(l.LgaCode)
                            select new
                            {
                                LgaName = t.LgaName,
                                IdsName = r.IdsName,
                                Year = l.Yr,
                                NoOfBsn = l.NoOfBsn
                            }).ToList();

                var json = JsonConvert.SerializeObject(list);
                return json;

            }
            else // proportion of person
            {
                var list = (from r in _context.Idsmas
                            join l in _context.Poetbl on r.IdsCode equals l.IdsCode
                            join t in _context.Lgamas on l.LgaCode equals t.LgaCode
                            where industries.Contains(r.IdsName) && regions.Contains(l.LgaCode)
                            select new
                            {
                                LgaName = t.LgaName,
                                IdsName = r.IdsName,
                                Year = l.Yr,
                                Proportion = l.Proportion
                            }).ToList();

                var json = JsonConvert.SerializeObject(list);
                return json;
            }
        }


        [HttpPost]
        public string getUnemployment()
        {
            var list = (from r in _context.Ueptbl
                        join t in _context.Lgatbl on r.LgaCode equals t.LgaCode
                        select new
                        {
                            LgaCode = t.LgaCode,
                            LgaName = t.NameRent,
                            Rate = r.UnempRate,
                            Color = colorDisplay.getUnempColor(r.UnempRate)
                        }).ToList();
            
            var json = JsonConvert.SerializeObject(list);
            return json;

        }


        [HttpPost]
        public string getIncome()
        {
            var list = (from r in _context.Inctbl
                        join t in _context.Lgatbl on r.LgaCode equals t.LgaCode
                        select new
                        {
                            LgaCode = t.LgaCode,
                            LgaName = t.NameRent,
                            Income = r.MeTtlInc,
                            Color = colorDisplay.getIncomeColor(r.MeTtlInc.Value)
                        }).ToList();

            var json = JsonConvert.SerializeObject(list);
            return json;

        }
    }


}