using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class locationsController : Controller
    {
        // GET: locations
        public ActionResult Index()
        {
            return View();
        }

    }
}
