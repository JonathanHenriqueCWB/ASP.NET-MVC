using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto002_Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        //Metodos Actions retornão uma view, normalmente do nome do metodo
        public ActionResult Contar() {

            ViewBag.Message = "Looping For de 0 a 10";

            return View();
        }
    }
}