using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using xmlParse.Models;

namespace xmlParse.Controllers
{
    public class CampgroundsController : Controller
    {
        public IActionResult Index(string selectState)
        {
            var client = new HttpClient();
            var quote = new CampgroundRepository(client);

            List<Campgrounds> campground = quote.GetCampgrounds(selectState);

            return View(campground);
        }
    }
}
