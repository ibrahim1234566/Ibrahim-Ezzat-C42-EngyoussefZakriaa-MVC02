using Microsoft.AspNetCore.Mvc;

namespace ibrahimEzzat_C42_EngyoussefZakriaa_MVC02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("this is index action");
        }

        public string AboutUs()
        {
            return "this is AboutUs action";
        }
    }
}
