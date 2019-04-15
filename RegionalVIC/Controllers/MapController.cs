﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegionalVIC.Models.DB;

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


        //getMedian(allCode[i], sel1, sel2)
        [HttpPost]
        public Object getMedian(string code, string bedroom, string type)
        {
            int bedno = Int32.Parse(bedroom);
            {
                var list = _context.Rtrtbl
                    .Where(r => r.LgaCode.Contains(code) && (int)r.NoOfBedrm == bedno && r.Yr.Equals(2018) && r.Typ.Contains(type)).ToList();
                //Need ore task sort for years
                var median = list.Count > 0 ? list[0].Median : 0;
                return "{median:'" + median + "', code:'" + code + "'}";
            }

        }
    }
}