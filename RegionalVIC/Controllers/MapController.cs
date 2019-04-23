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
    public class chartItem
    {
        public string label;
        public string value;

        public chartItem()
        {

        }

        public chartItem(string label, string value)
        {
            this.label = label;
            this.value = value;
        }
    }
    public class recommendationItem
    {
        public string code;
        public double rate;
        public string name;
        public string region;
        public string type;
        public byte bedroom;

        public recommendationItem()
        {

        }

        public recommendationItem(string code, double rate, string name, string region, string type, byte bedroom)
        {
            this.code = code;
            this.rate = rate;
            this.name = name;
            this.region = region;
            this.type = type;
            this.bedroom = bedroom;
        }

        //Get acommondation rating
        public static double getRatingByPrice(int? d)
        {
            return d > 550 ? 0 :
                d > 500 ? 1 :
                    d > 450 ? 2 :
                        d > 400 ? 3 :
                            d > 350 ? 4 :
                                d > 300 ? 5 :
                                    d > 250 ? 6 :
                                        d > 225 ? 7 :
                                            d > 200 ? 8 :
                                                d > 150 ? 9 :
                                                    10;
        }

        //Get criminal rating
        public static double getRatingByCrime(decimal d)
        {
            return d > 10 ? 0 :
                d > 9 ? 1 :
                    d > 8 ? 2 :
                        d > 7 ? 3 :
                            d > 6 ? 4 :
                                d > 5 ? 5 :
                                    d > 4 ? 6 :
                                        d > 3 ? 7 :
                                            d > 2 ? 8 :
                                                d > 1 ? 9 : 10;
        }

        //Get population rating
        public static double getRatingByDensity(decimal d)
        {
            return d > 200 ? 0 :
                d > 150 ? 1 :
                    d > 100 ? 5 :
                        d > 50 ? 7 :
                            d > 25 ? 8 :
                                d > 15 ? 9 :
                                    d > 10 ? 10 :
                                        d > 8 ? 8 :
                                            d > 7 ? 7 :
                                                d > 6 ? 6 :
                                                    d > 5 ? 5 :
                                                        d > 4 ? 4 :
                                                            d > 3 ? 3 :
                                                                d > 2 ? 2 :
                                                                    d > 1 ? 1 : 0;
        }
    }
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
        public Object getContent(char require, string bedroom = "0", string type = "house")
        {
            List<colorDisplay> result = new List<colorDisplay>();
            var regionsList = _context.Lgatbl.ToList();

            if (require == 97)//97 'a' 
            {
                int bedno = Int32.Parse(bedroom);
                var list = _context.Rtrtbl
                           .Where(r => r.LgaCode != "00000" && (int)r.NoOfBedrm == bedno && r.Yr.Equals(2018) && r.Quarter.Equals(3) && r.Typ.Contains(type)).ToList();

                foreach (var t in regionsList)
                {
                    int median = 0;

                    string display = "No record";
                    foreach (var l in list)
                    {

                        if (l.LgaCode.Contains(t.LgaCode))
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
            }
            else if (require == 99)//99 'c'
            {
                var list = _context.Critbl
                     .Where(r => r.LgaCode != "00000" && r.YrEnd.Equals(2018)).ToList();

                foreach (var t in regionsList)
                {
                    decimal rate = 0;
                    int icdNum = 0;
                    string display = "No record";
                    foreach (var l in list)
                    {

                        if (l.LgaCode.Contains(t.LgaCode))
                        {
                            rate = Math.Round(l.Rate, 2);
                            icdNum = l.IncdRcd;
                            display = rate != 0 ? "Criminal Rate: " + rate + "%. <p>Incident number: " + icdNum + "</p>" : "No record";
                            break;
                        }
                    }
                    colorDisplay cd = new colorDisplay(Int32.Parse(t.LgaCode), colorDisplay.getCrimeColor(rate), display);
                    result.Add(cd);
                }
            }
            else if (require == 100)//100 'd'
            {
                var list = _context.Ppltbl
                     .Where(r => r.LgaCode != "00000").ToList();

                foreach (var t in regionsList)
                {
                    decimal density = 0;
                    int population = 0;

                    string display = "No record";
                    foreach (var l in list)
                    {
                        if (l.LgaCode.Contains(t.LgaCode))
                        {
                            density = Math.Round(l.Density, 2);
                            population = l.Popul;
                            display = density != 0 ? "Density: " + density + ". <p>Population: " + population + "</p>" : "No record";
                            break;
                        }
                    }
                    colorDisplay cd = new colorDisplay(Int32.Parse(t.LgaCode), colorDisplay.getDesyColor(density), display);
                    result.Add(cd);
                }
            }


            var json = JsonConvert.SerializeObject(result);
            return json;

        }



        [HttpPost]
        public string getRegions(string country)
        {
            var list = (from r in _context.Cmmtbl
                        join l in _context.Cobmas on r.CobCode equals l.Seq
                        join t in _context.Lgatbl on r.LgaCode equals t.LgaCode
                        where l.Cob == country
                        select new
                        {
                            LgaName = t.LgaName,
                            Percnt = r.Percnt,
                            Cob = l.Cob
                        }).ToList();


            list = list.OrderByDescending(t => t.Percnt).ToList();

            List<chartItem> chartList = new List<chartItem>();
            //string[] label = new string[list.Count];
            //string[] value = new string[list.Count];
            for (var i = 0; i < list.Count; i++)
            {
                var label = list[i].LgaName;
                var value = list[i].Percnt.ToString();

                chartItem item = new chartItem(label, value);
                chartList.Add(item);
            }

            var json = JsonConvert.SerializeObject(chartList);
            return json;

        }

        [HttpPost]
        public string getCountry(string code)
        {
            var list = (from r in _context.Cobtbl
                        join l in _context.Cobmas on r.CobCode equals l.Seq
                        where r.LgaCode == code
                        select new
                        {
                            LgaCode = r.LgaCode,
                            Percnt = r.Percnt,
                            Cob = l.Cob
                        }).ToList();


            list = list.OrderByDescending(t => t.Percnt).ToList();

            List<chartItem> chartList = new List<chartItem>();
            //string[] label = new string[list.Count];
            //string[] value = new string[list.Count];
            for (var i = 0; i < list.Count; i++)
            {
                var label = list[i].Cob;
                var value = list[i].Percnt.ToString();

                chartItem item = new chartItem(label, value);
                chartList.Add(item);
            }

            var json = JsonConvert.SerializeObject(chartList);
            return json;

        }


        [HttpPost]
        public string getLan(string code)
        {
            var list = (from r in _context.Lggtbl
                        join l in _context.Lggmas on r.LangCode equals l.Seq
                        where r.LgaCode == code
                        select new
                        {
                            LgaCode = r.LgaCode,
                            Percnt = r.Percnt,
                            Lang = l.Lang
                        }).ToList();


            list = list.OrderByDescending(t => t.Percnt).ToList();

            List<chartItem> chartList = new List<chartItem>();
            //string[] label = new string[list.Count];
            //string[] value = new string[list.Count];
            for (var i = 0; i < list.Count; i++)
            {
                var label = list[i].Lang;
                var value = list[i].Percnt.ToString();

                chartItem item = new chartItem(label, value);
                chartList.Add(item);
            }

            var json = JsonConvert.SerializeObject(chartList);
            return json;

        }

        [HttpPost]
        public string filterRent(int min, int max)
        {
            string display = "";
            var list = (from r in _context.Rtrtbl
                join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                where r.LgaCode != "00000" && r.Yr.Equals(2018) && r.Quarter.Equals(3) && r.Median > 0 && (r.Median >= min && r.Median <= max)
                select new
                {
                    LgaCode = r.LgaCode,
                    Median = r.Median,
                    LgaName = l.NameRent,
                    Region = l.Region,
                    Bedroom = r.NoOfBedrm,
                    Type = r.Typ
                }).ToList();

            list = list.OrderBy(t => t.Median).ToList();
            if (list.Count == 0)
            {
                display = "<div class=\"list-group-item list-group-item-action flex-column align-items-start\"> " +
                   "<div class=\"d-flex w-100 justify-content-between\" > <h6 class=\"mb-1\">" +
                   "No record within this price range</h6> <small class=\"text-muted\" ></small> </div> <p class=\"mb-1\">" +
                   "Change your price range and try again</p> </div>";
            }
            foreach (var i in list)
            {
                display += "<a href=\"javascript:flytoPoly(" + i.LgaCode + ")\" class=\"list-group-item list-group-item-action flex-column align-items-start\"> " +
                    "  <div class=\"d-flex w-100 justify-content-between\" > <h6 class=\"mb-1\">"
                    + i.LgaName + " - " + i.Region + "</h6> <small class=\"text-muted\" >$"
                    + i.Median + "</small> </div> <p class=\"mb-1\">"
                    + i.Bedroom + " bedroom(s) " + FirstCharToUpper(i.Type) + "</p> </a>";
            }
            return display;
        }

        [HttpPost]
        public string getRecommendation(int min, int max, float acmWeight, float crmWeight, float pouWeight)
        {
            string display = "";
            var list = (from r in _context.Rtrtbl
                        join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                        join p in _context.Ppltbl on r.LgaCode equals p.LgaCode
                        join c in _context.Critbl on r.LgaCode equals c.LgaCode
                        where r.LgaCode != "00000" && r.Yr.Equals(2018) && r.Quarter.Equals(3) &&
                            r.Median > 0 && (r.Median >= min && r.Median <= max) &&
                            c.YrEnd.Equals(2018) && c.Rate > 0 &&
                            p.Density > 0
                        select new
                        {
                            LgaCode = r.LgaCode,
                            Median = r.Median,
                            LgaName = l.NameRent,
                            Region = l.Region,
                            Bedroom = r.NoOfBedrm,
                            Type = r.Typ,
                            Rate = c.Rate,
                            IciNum = c.IncdRcd,
                            Density = p.Density,
                            Population = p.Popul
                        }).ToList();

            if (list.Count == 0)
            {
                display = "<div class=\"list-group-item list-group-item-action flex-column align-items-start\"> " +
                   "<div class=\"d-flex w-100 justify-content-between\" > <h6 class=\"mb-1\">" +
                   "No record within this price range</h6> <small class=\"text-muted\" ></small> </div> <p class=\"mb-1\">" +
                   "Change your price range and try again</p> </div>";
            }

            var regionsList = _context.Lgatbl.ToList();
            List<recommendationItem> rates = new List<recommendationItem>();
            foreach (var i in list)
            {

                var rate = acmWeight * recommendationItem.getRatingByPrice(i.Median) +
                    crmWeight * recommendationItem.getRatingByCrime(i.Rate) +
                    pouWeight * recommendationItem.getRatingByDensity(i.Density);

                recommendationItem item = new recommendationItem(i.LgaCode, rate, i.LgaName, i.Region, i.Type, i.Bedroom ?? default(byte));
                rates.Add(item);

            }


            rates = rates.OrderByDescending(t => t.rate).ToList();
            
            for (var j = 0; j < 10; j++)
            {
                display += "<a href=\"javascript:flytoPoly(" + rates[j].code + ")\" class=\"list-group-item list-group-item-action flex-column align-items-start\"> " +
                    "  <div class=\"d-flex w-100 justify-content-between\" > <h6 class=\"mb-1\">"
                    + rates[j].name + " - " + rates[j].region + "</h6> <small class=\"text-muted\" >Top "
                    + (j+1) + "</small> </div> <p class=\"mb-1\">" + "</p> <small>" + rates[j].bedroom + " bedroom(s) " + FirstCharToUpper(rates[j].type) + "</small> </a>";
                
            }
            return display;
        }

        public string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
    }
}