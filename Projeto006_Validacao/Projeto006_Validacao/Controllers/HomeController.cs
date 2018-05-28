using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto006_Validacao.Models;

namespace Projeto006_Validacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }
        

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {

            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }
        

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }


        //Validação por parte do servidor no banco de dados
        public ActionResult LoginUnico(string login)
        {
            //Collection Um array de coleção (aceita objetos)
            var bancoExemplo = new Collection<string>
                {
                    "Jonathan",
                    "Marcos",
                    "Mario"
                };
            return Json(bancoExemplo.All(nome => nome.ToLower() != login.ToLower() ) , JsonRequestBehavior.AllowGet);
        }

    }
}