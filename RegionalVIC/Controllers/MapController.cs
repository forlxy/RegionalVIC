using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegionalVIC.Models;
using RegionalVIC.Models.DB;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RegionalVIC.Controllers
{
    //Temporate store item
    public class regionItem
    {
        public string code;
        public string name;

        public regionItem()
        {

        }

        public regionItem(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }
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
    public class chartItemEx
    {
        public string code;
        public string label;
        public string value;

        public chartItemEx()
        {

        }

        public chartItemEx(string code, string label, string value)
        {
            this.code = code;
            this.label = label;
            this.value = value;
        }
    }
    public class recommendationItem
    {
        public string code;
        public double rate;
        public double rater;
        public double rates;
        public double ratep;
        public double ratec;
        public double ratei;
        public string name;
        public string region;
        public int NoOfBsn;

        public recommendationItem()
        {

        }

        public recommendationItem(string code, double rate, double rater, double rates, double ratep, double ratec, double ratei, string name, string region, int NoOfBsn)
        {
            this.code = code;
            this.rate = rate;
            this.rater = rater;
            this.rates = rates;
            this.ratep = ratep;
            this.ratec = ratec;
            this.ratei = ratei;
            this.name = name;
            this.region = region;
            this.NoOfBsn = NoOfBsn;
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

        public static double getRatingByCulture(int d)
        {
            return (11 - d) > 0 ? 11 - d : 0;
        }

        //Get job rating
        public static double getRatingByJob(int d)
        {
            return d > 1000 ? 10 :
                d > 500 ? 9 :
                    d > 200 ? 8 :
                        d > 150 ? 7 :
                            d > 100 ? 6 :
                                d > 50 ? 5 :
                                    d > 35 ? 4 :
                                        d > 20 ? 3 :
                                            d > 15 ? 2 :
                                                d > 5 ? 1 : 0;
        }

    }
    public class MapController : Controller
    {
        private static JObject codeColors;

        private RegionalVICContext _context;
        public MapController(RegionalVICContext context)
        {
            _context = context;
        }

        //Index page
        public ActionResult Index()
        {
            return View();
        }


        //Recommendation page
        public ActionResult Recommendation()
        {
            return View();
        }

        //Get all country
        [HttpPost]
        public string getAllCountry()
        {
            var list = _context.Cobmas.ToList();

            List<string> result = new List<string>();
            foreach (var i in list)
            {
                result.Add(i.Cob);
            }


            var json = JsonConvert.SerializeObject(result);
            return json;

        }

        //Get all regions
        [HttpPost]
        public string getAllRegions()
        {
            var list = _context.Lgatbl.Where(r => r.LgaCode != "00000" && r.Status == "R").ToList();


            List<regionItem> result = new List<regionItem>();
            foreach (var i in list)
            {
                result.Add(new regionItem(i.LgaCode, i.NameRent));
            }

            var json = JsonConvert.SerializeObject(result);
            return json;
        }

        //Get industry list
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


        //get data For barchart
        [HttpPost]
        public string getBarchartData(string[] industries, string[] regions, string option)
        {

            //join t in _context.Poetbl on r.IdsCode equals t.IdsCode

            if (option.Contains("0")) // Number of business
            {
                var list = (from r in _context.Idsmas
                            join l in _context.Nbitbl on r.IdsCode equals l.IdsCode
                            join t in _context.Lgatbl on l.LgaCode equals t.LgaCode
                            where industries.Contains(r.IdsName) && regions.Contains(l.LgaCode)
                            select new
                            {
                                LgaName = t.NameRent,
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
                            join t in _context.Lgatbl on l.LgaCode equals t.LgaCode
                            where industries.Contains(r.IdsName) && regions.Contains(l.LgaCode)
                            select new
                            {
                                LgaName = t.NameRent,
                                IdsName = r.IdsName,
                                Year = l.Yr,
                                Proportion = l.Proportion
                            }).ToList();

                var json = JsonConvert.SerializeObject(list);
                return json;
            }
        }

        //Get unemployment rate list
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

        //Get income list
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
        //Show more info about recommendation result
        [HttpPost]
        public string getMore(string code)
        {

            var item = (from a in _context.Lgamas
                         join l in _context.Lgatbl on a.LgaCode equals l.LgaCode
                         join r in _context.Rtrtbl on a.LgaCode equals r.LgaCode
                         join p in _context.Ppltbl on a.LgaCode equals p.LgaCode
                         join c in _context.Critbl on a.LgaCode equals c.LgaCode
                         
                         where a.LgaCode.Contains(code) && l.Status == "R" && r.Yr.Equals(2018) && r.Quarter.Equals(3) && r.Typ.Contains("all") &&
                             r.Median > 0 && 
                             c.YrEnd.Equals(2018) && c.Rate > 0 &&
                             p.Density > 0
                         select new
                         {
                             LgaCode = a.LgaCode,
                             Median = r.Median,
                             LgaName = a.LgaBdesc,
                             Region = l.Region,
                             Rate = c.Rate,
                             LgaImage = a.LgaImage,
                             Density = p.Density,
                             Population = p.Popul
                         }).First();
            
            
            var json = JsonConvert.SerializeObject(item);
            return json;

        }

        //Get info of a region
        [HttpPost]
        public string getInfo(string code)
        {


            var item = (from r in _context.Lgamas
                        join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                        where r.LgaCode.Contains(code) && l.Status == "R"
                        select new
                        {
                            LgaName = r.LgaBdesc,
                            LgaCode = r.LgaCode,
                            LgaRegion = l.Region,
                            LgaDesc = r.LgaDesc,
                            LgaImage = r.LgaImage,
                            LgaVideo = r.LgaVideo
                        }).First();

            var tmpObject = new
            {
                name = item.LgaName,
                region = item.LgaRegion,
                descrption = item.LgaDesc,
                image = item.LgaImage,
                video = item.LgaVideo.Replace("watch?v=", "embed/")
            };

            var json = JsonConvert.SerializeObject(tmpObject);
            return json;

        }
        //Store color in map. Deprecated
        [HttpPost]
        public void setCodeColors(string json)
        {

            codeColors = JObject.Parse(json);
        }
        //Get chro map result
        [HttpPost]
        public Object getContent(char require, string bedroom = "0", string type = "house")
        {
            string json = "";
            if (require == 97)//97 'a' 
            {
                int bedno = Int32.Parse(bedroom);

                var list = (from r in _context.Rtrtbl
                            join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                            where r.LgaCode != "00000" && r.Yr.Equals(2018) && r.Quarter.Equals(3)
                            && r.Typ.Contains(type) && (int)r.NoOfBedrm == bedno && l.Status == "R"
                            select new
                            {
                                LgaCode = r.LgaCode,
                                Median = r.Median,
                                LgaName = l.NameRent,
                                Region = l.Region,
                                NoOfBedrm = r.NoOfBedrm,
                                Typ = r.Typ,
                                Color = colorDisplay.getAcomColor(r.Median.Value)
                            }).ToList();


                list = list.OrderBy(t => t.Median).ToList();

                json = JsonConvert.SerializeObject(list);
            }
            else if (require == 99)//99 'c'
            {
                //var list = _context.Critbl
                //     .Where(r => r.LgaCode != "00000" && r.YrEnd.Equals(2018)).ToList();

                var list = (from r in _context.Critbl
                            join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                            where r.LgaCode != "00000" && r.YrEnd.Equals(2018) && l.Status == "R"
                            select new
                            {
                                LgaCode = r.LgaCode,
                                LgaName = l.NameRent,
                                Region = l.Region,
                                Rate = r.Rate,
                                IncdRcd = r.IncdRcd,
                                Color = colorDisplay.getCrimeColor(r.Rate)
                            }).ToList();

                list = list.OrderBy(t => t.Rate).ToList();

                json = JsonConvert.SerializeObject(list);
            }
            else if (require == 100)//100 'd'
            {
                //var list = _context.Ppltbl
                //     .Where(r => r.LgaCode != "00000").ToList();


                var list = (from r in _context.Ppltbl
                            join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                            where r.LgaCode != "00000" && l.Status == "R"
                            select new
                            {
                                LgaCode = r.LgaCode,
                                LgaName = l.NameRent,
                                Region = l.Region,
                                Density = r.Density,
                                Popul = r.Popul,
                                Color = colorDisplay.getDesyColor(r.Density)
                            }).ToList();

                list = list.OrderBy(t => t.Density).ToList();

                json = JsonConvert.SerializeObject(list);
            }


            return json;
        }


        //Get region result
        [HttpPost]
        public string getRegions(string country)
        {
            var list = (from r in _context.Cmmtbl
                        join l in _context.Cobmas on r.CobCode equals l.Seq
                        join t in _context.Lgatbl on r.LgaCode equals t.LgaCode
                        where l.Cob == country
                        select new
                        {
                            LgaCode = t.LgaCode,
                            LgaName = t.LgaName,
                            Percnt = r.Percnt,
                            Cob = l.Cob,
                            Status = t.Status
                        }).ToList();


            list = list.OrderByDescending(t => t.Percnt).ToList();

            List<chartItemEx> chartList = new List<chartItemEx>();
            //string[] label = new string[list.Count];
            //string[] value = new string[list.Count];
            for (var i = 0; i < list.Count; i++)
            {
                string code;
                if (list[i].Status == "R")
                {

                    code = list[i].LgaCode;
                }
                else
                {
                    code = "-1";
                }
                var label = list[i].LgaName;
                var value = list[i].Percnt.ToString();

                chartItemEx item = new chartItemEx(code, label, value);
                chartList.Add(item);
            }

            var json = JsonConvert.SerializeObject(chartList);
            return json;

        }
        //Get country result
        [HttpPost]
        public string getCountry(string code)
        {
            var list = (from r in _context.Cobtbl
                        join l in _context.Cobmas on r.Cob equals l.Seq
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


        //Get lat and lon of a polygon
        [HttpPost]
        public string getLngLat(string code)
        {
            var item = (from r in _context.Lgamas
                        where r.LgaCode == code
                        select new
                        {
                            LgaCode = r.LgaCode,
                            Lat = r.LgaLatitude,
                            Lng = r.LgaLongitude
                        }).First();


            return "{ \"latitude\":" + item.Lat + ",\"longitude\": " + item.Lng + "}";

        }
        //Get language result
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
                            Lang = l.Language
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
        //Filter rent
        [HttpPost]
        public string filterRent(int min, int max, string bedroom = "", string type = "All")
        {

            string display = "";
            int bedno;
            if (type.Contains("All"))
            {
                bedno = 0;
                bedroom = "";
            }
            else
            {
                bedno = Int32.Parse(bedroom);
            }


            var list = (from r in _context.Rtrtbl
                join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                where r.LgaCode != "00000" && r.Yr.Equals(2018) && r.Quarter.Equals(3)
                        && l.Status == "R" && r.Median > 0 
                        && (r.Median >= min && r.Median <= max) 
                        && (type.Contains("ll") ? r.Typ.Contains("ll"): (r.Typ.Contains(type) && (int)r.NoOfBedrm == bedno))
                select new
                {
                    LgaCode = r.LgaCode,
                    Median = r.Median,
                    LgaName = l.NameRent,
                    Region = l.Region,
                    Bedroom = r.NoOfBedrm,
                    Type = r.Typ,
                    Color = colorDisplay.getAcomColor(r.Median.Value)
                }).ToList();

            list = list.OrderBy(t => t.Median).ToList();
            var msg = "";
            if (list.Count == 0)
            {
                msg = "Sorry, there is no record within this price range. But here is the result you might be interested in:";

                list = (from r in _context.Rtrtbl
                        join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                        where r.LgaCode != "00000" && r.Yr.Equals(2018) && r.Quarter.Equals(3)
                                && l.Status == "R" && r.Median > 0
                                && (type.Contains("ll") ? r.Typ.Contains("ll") : (r.Typ.Contains(type) && (int)r.NoOfBedrm == bedno))
                        select new
                        {
                            LgaCode = r.LgaCode,
                            Median = r.Median,
                            LgaName = l.NameRent,
                            Region = l.Region,
                            Bedroom = r.NoOfBedrm,
                            Type = r.Typ,
                            Color = colorDisplay.getAcomColor(r.Median.Value)
                        }).ToList();

                list = list.OrderBy(t => t.Median).ToList();
            }

            //List<string> tmpAreas = new List<string>();
            foreach (var i in list)
            {
                //tmpAreas.Add(i.LgaCode);
                display += "<a href=\"javascript:flytoPoly(" + i.LgaCode + ")\" class=\"list-group-item list-group-item-action flex-column align-items-start\"> " +
                    "  <div class=\"d-flex w-100 justify-content-between\" > <h4 class=\"mb-1\">"
                    + i.LgaName + " - " + i.Region + "</h4> <small class=\"text-muted\" >$"
                    + i.Median + "</small> </div> " +
                    "<div class=\"d-flex w-100 justify-content-between\" > " +
                    "<p class=\"mb-1\">"
                    + ((i.Bedroom == 0 ) ? "Average of All types" : (i.Bedroom + " bedroom(s) " + FirstCharToUpper(i.Type)) )
                    + "</p> " +
                    "</div></a>";
            }
            //string[] areas = tmpAreas.Distinct().ToArray();
            var tmpObject = new
            {
                areas = list,
                display = display,
                msg = msg
            };
            return JsonConvert.SerializeObject(tmpObject);
        }
        //get recommendation
        [HttpPost]
        public string getRecommendation(int min, int max, float acmWeight, float crmWeight, float pouWeight, float culWeight, float jobWeight, string country = " ", string industry = " ")
        {
            string display = "";

            var query = (from r in _context.Rtrtbl
                         join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                         join p in _context.Ppltbl on r.LgaCode equals p.LgaCode
                         join c in _context.Critbl on r.LgaCode equals c.LgaCode
                         where r.LgaCode != "00000" && r.Yr.Equals(2018) && r.Quarter.Equals(3) && r.Typ.Contains("all") &&
                             r.Median > 0 && (r.Median >= min && r.Median <= max) &&
                             c.YrEnd.Equals(2018) && c.Rate > 0 &&
                             p.Density > 0 && l.Status == "R"
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
                             Population = p.Popul,
                             Rank = (short)11,
                             Cob = "",
                             NoOfBsn = 0,
                             IdsName = ""
                         });


            if (!String.IsNullOrEmpty(country))
            {
                query = (from r in query
                         join d in _context.Cobtbl on r.LgaCode equals d.LgaCode
                         join m in _context.Cobmas on d.Cob equals m.Seq
                         where m.Cob.Contains(country)
                         select new
                         {
                             LgaCode = r.LgaCode,
                             Median = r.Median,
                             LgaName = r.LgaName,
                             Region = r.Region,
                             Bedroom = r.Bedroom,
                             Type = r.Type,
                             Rate = r.Rate,
                             IciNum = r.IciNum,
                             Density = r.Density,
                             Population = r.Population,
                             Rank = d.Rank,
                             Cob = m.Cob,
                             NoOfBsn = r.NoOfBsn,
                             IdsName = r.IdsName
                         });
            }

            if (!String.IsNullOrEmpty(industry))
            {
                query = (from r in query
                         join i in _context.Nbitbl on r.LgaCode equals i.LgaCode
                         join s in _context.Idsmas on i.IdsCode equals s.IdsCode
                         where s.IdsName.Contains(industry)
                         select new
                         {
                             LgaCode = r.LgaCode,
                             Median = r.Median,
                             LgaName = r.LgaName,
                             Region = r.Region,
                             Bedroom = r.Bedroom,
                             Type = r.Type,
                             Rate = r.Rate,
                             IciNum = r.IciNum,
                             Density = r.Density,
                             Population = r.Population,
                             Rank = r.Rank,
                             Cob = r.Cob,
                             NoOfBsn = i.NoOfBsn,
                             IdsName = s.IdsName
                         });
            }

            var msg = "";
            var list = query.ToList();
            if (list.Count == 0)
            {

                msg = "Sorry, no exact matches found. But here is the result you might be interested in:";
                query = (from r in _context.Rtrtbl
                             join l in _context.Lgatbl on r.LgaCode equals l.LgaCode
                             join p in _context.Ppltbl on r.LgaCode equals p.LgaCode
                             join c in _context.Critbl on r.LgaCode equals c.LgaCode
                             where r.LgaCode != "00000" && r.Yr.Equals(2018) && r.Quarter.Equals(3) && r.Typ.Contains("all") &&
                                 r.Median > 0 && 
                                 c.YrEnd.Equals(2018) && c.Rate > 0 &&
                                 p.Density > 0 && l.Status == "R"
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
                                 Population = p.Popul,
                                 Rank = (short)11,
                                 Cob = "",
                                 NoOfBsn = 0,
                                 IdsName = ""
                             });

                list = query.ToList();
            }

            var regionsList = _context.Lgatbl.ToList();
            List<recommendationItem> rates = new List<recommendationItem>();
            foreach (var i in list)
            {

                var rate1 = recommendationItem.getRatingByPrice(i.Median);
                var rate2 = recommendationItem.getRatingByCrime(i.Rate);
                var rate3 = recommendationItem.getRatingByDensity(i.Density);
                var rate4 = culWeight == 0 ? 0 : recommendationItem.getRatingByCulture(i.Rank);
                var rate5 = recommendationItem.getRatingByJob(i.NoOfBsn);
                var rate = acmWeight * rate1 + crmWeight * rate2 + pouWeight * rate3 + culWeight * rate4 + jobWeight * rate5;

                recommendationItem item = new recommendationItem(i.LgaCode, rate, rate1, rate2, rate3, rate4, rate5, i.LgaName, i.Region, i.NoOfBsn);
                rates.Add(item);

            }


            rates = rates.GroupBy(x => x.code)
                         .Select(g => g.OrderByDescending(y => y.rate).First())
                         .ToList();

            rates = rates.OrderByDescending(t => t.rate).ToList();

            List<recommendationItem> areas = new List<recommendationItem>();
            
            for (var j = 0; j < ((rates.Count < 10)? rates.Count : 10); j++)
            {
                areas.Add(rates[j]);
                display += "<a href=\"javascript:showMore(" + rates[j].code + "," + rates[j].rater + "," + rates[j].rates + "," + rates[j].ratep + "," + rates[j].ratec + "," + rates[j].ratei + "," + rates[j].NoOfBsn + ")\" class=\"list-group-item list-group-item-action flex-column align-items-start\"> " +
                    "<div class=\"d-flex w-100 justify-content-between\" > " +
                    "<h4 class=\"mb-1\">"
                    + rates[j].name + " - " + rates[j].region + "</h4> <small class=\"text-muted\" >Top "
                    + (j+1) + "</small> </div>" +
                    "<div class=\"d-flex w-100 justify-content-between\" > " +
                    "<div> Rating </div>" +
                    //"<div>" + rates[j].bedroom + " bedroom(s) " + FirstCharToUpper(rates[j].type) + "</div> " +
                    "<small class=\"text-muted\"><b>" + Math.Round(rates[j].rate,2) + " of 10</b></small> " +
                    "</div></a>";
                
            }
            var tmpObject = new
            {
                areas = areas,
                display = display,
                msg = msg
            };
            return JsonConvert.SerializeObject(tmpObject);
        }
        //First letter to uppercase
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