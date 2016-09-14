using System;
using System.Linq;
using System.Web.Mvc;

namespace AngularJSiScrollDirectiveSamples.Controllers
{
    public class DataController : Controller
    {
        public ActionResult List()
        {
            var rand = new Random();

            var list = Enumerable.Repeat(0, 50).Select(i => new { number = rand.Next(0, 100) }).ToArray();

            return this.Json(list);
        }
    }
}