 using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto005_Validacao.Models;

namespace Projeto005_Validacao.Controllers
{
    public class PessoaController : Controller
    {

        //Metodo com um formulario
        public ActionResult Index()
        {
            //Instanciando uma nova pessoa do Model
            var pessoa = new Pessoa();

            //Retorna um objeto para uma view (Obrigatiriamente tipada)
            return View(pessoa);
        }

        //Valida o objeto vindo da view co formulario
        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            /*
                //Validação nome
                if (string.IsNullOrEmpty(pessoa.Nome))
                {
                    ModelState.AddModelError("Nome", "O campo Nome é Obrigatório!!");
                }

                //Validação de senhas
                if (pessoa.Senha != pessoa.ComfirmaSenha)
                {
                    ModelState.AddModelError("", "As senhas devem ser iguais");
                }
                
            */

            //Validação ModelState, verefica se e valida
            if (ModelState.IsValid)
                {
                    //Caso true retorna um objeto pessoa a classe Resultado
                    return View("Resultado", pessoa);
                }
                //Caso false retorna a view index com objeto invalidade
                return View(pessoa);
            

        }

        //Caso validação = true vira para esse método onde enviara o objeto a view Resultado e exibira
        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoGenerico = new Collection<string>
            {
                "Jonathan",
                "Henrique",
                "Alves"
            };

            return Json(bancoGenerico.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}