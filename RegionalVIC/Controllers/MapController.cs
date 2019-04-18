using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegionalVIC.Models;
using RegionalVIC.Models.DB;
using Newtonsoft.Json;

namespace RegionalVIC.Controllers
{
    public class MapController : Controller
    {
        private regionalVICContext _context;
        public MapController(regionalVICContext context)
        {
            _context = context;
        }
        // GET: Map
        public ActionResult Index()
        {
            //var first = _context.Rtrtbl;
            //var second = _context.Critbl;
            //var third = _context.Ppltbl;

            return View(/*Tuple.Create(first, second, third)*/);
        }

        // GET: Map/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Map/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Map/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Map/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Map/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Map/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Map/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        public Object getMedian(string code, string bedroom, string type)
        {
            int bedno = Int32.Parse(bedroom);
            {
                var list = _context.Rtrtbl
                    .Where(r => r.LgaCode.Contains(code) && (int)r.NoOfBedrm == bedno && r.Yr.Equals(2018) && r.Typ.Contains(type)).ToList();
                //Need ore task sort for years
                var median = list.Count > 0 ? list[0].Median : 0;
                return "{\"median\":\"" + median + "\", \"code\":\"" + code + "\"}";
            }

        }

        [HttpPost]
        public Object getAllMedian(string bedroom, string type)
        {
            List<colorDisplay> result = new List<colorDisplay>();
            var regionsList = _context.Lgatbl.ToList();
            int bedno = Int32.Parse(bedroom);
            var list = _context.Rtrtbl
                       .Where(r => r.LgaCode != "" && (int)r.NoOfBedrm == bedno && r.Yr.Equals(2018) && r.Quarter.Equals(3) && r.Typ.Contains(type)).ToList();

            foreach (var t in regionsList)
            {
                int median = 0;

                string display = "No record";
                foreach (var l in list)
                { 

                    if(l.LgaCode.Contains(t.LgaCode))
                    {
                        //Need ore task sort for years
                        median = l.Median ?? default(int);
                        display = median != 0 ? "The median of the " + type + " (bedroom: " + bedno + ") is $" + median + "." : "No record";
                        break;
                    }
                }
                colorDisplay cd = new colorDisplay(Int32.Parse(t.LgaCode), colorDisplay.getAcomColor(median), display);
                result.Add(cd);
            }

            var json = JsonConvert.SerializeObject(result);
            return json;

        }

        [HttpPost]
        public Object getCrmRate(string code)
        {
            {
                var list = _context.Critbl
                     .Where(r => r.LgaCode.Contains(code) && r.YrEnd.Equals(2018)).ToList();
                //Need ore task sort for years
                var rate = list.Count > 0 ? list[0].Rate : 0;
                var icdNum = list.Count > 0 ? list[0].IncdRcd : 0;
                return "{\"rate\":\"" + rate + "\", \"incident\":\"" + icdNum + "\", \"code\":\"" + code + "\"}";
            }

        }

        [HttpPost]
        public Object getDensity(string code)
        {
            {
                var list = _context.Ppltbl
                    .Where(r => r.LgaCode.Contains(code)).ToList();
                //Need ore task sort for years
                var density = list.Count > 0 ? list[0].Density : 0;
                var population = list.Count > 0 ? list[0].Popul : 0;
                return "{\"density\":\"" + density + "\", \"population\":\"" + population + "\", \"code\":\"" + code + "\"}";
            }
             
        }

        [HttpPost]
        public Object saveText(string text)
        {
            System.IO.File.WriteAllText(@"test.js", text);
            return "yes";
        }

    }
}