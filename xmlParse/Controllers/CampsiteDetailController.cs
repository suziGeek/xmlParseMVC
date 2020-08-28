using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xmlParse.Models;

namespace xmlParse.Controllers
{
    public class CampsiteDetailController : Controller
    {

        public ActionResult Index()
        {

            var client = new HttpClient();
            var quote = new CampsiteDetailRepository(client);


            //Console.WriteLine($"Kanye: {quote.Kanye()}");

            //Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");
            var campsites = quote.GetCamperDetail();

            return View(campsites);
        }
    }
}
