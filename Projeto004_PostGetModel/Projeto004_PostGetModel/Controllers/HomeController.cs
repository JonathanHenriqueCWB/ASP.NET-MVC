using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto004_PostGetModel.Models;

namespace Projeto004_PostGetModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Visualizar(string nome, string sobrenome, string email)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Sobrenome = sobrenome;
            pessoa.Email = email;

            return View(pessoa);
        }

    }
}