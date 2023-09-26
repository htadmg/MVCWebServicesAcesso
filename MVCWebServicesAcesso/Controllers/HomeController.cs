using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebServicesAcesso.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var service = new ClienteServiceReference.Service1Client();
            var clientes = service.All();
            var cliente = service.GetData(1);
            var correto = service.Save("danilo", "36236531425");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}