using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Importa a classe Models para poder instanciar um objeto aqui, e também receber
using Projeto003_PostGetModel.Models;

namespace Projeto003_PostGetModel.Controllers
{
    public class HomeController : Controller
    {   
        //Get, por defoult todas as ACTIONS respondem por um get
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                PessoaId = 1234,
                Nome = "Jonathan Henrique",
                Email = "123@abc"
            };

            //ViewData["escolhaNomeParametro"] = objeto.atributo;
            /*
            ViewBag.CodigoPessoa = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["RedeSocial"] = pessoa.Twitter;
            */
            return View(pessoa); // Retornara objeto pessoa para view
        }

        //Método recebera parametros de um formlario
        [HttpPost] //Recebe parametros do post, Obrigatorio parametros ser o mesmo que o id
        public ActionResult Lista(Pessoa pessoa)
        {
            /*
            //ViewDATA["Atibuto da classe"] = nome do parametro, id do formulario
            //Tipo de parametros: string nome, string email, int codigo
                ViewData["Nome"] = nome;
                ViewData["Email"] = email;
                ViewData["PessoaId"] = codigo;
        
            //ViewBag.NomeAtribtuo = parametro nome, id do formulario
            //Tipo de parametro: string nome, string email, int codigo
                ViewBag.Nome = nome;
                ViewBag.Email = email;
                ViewBag.PessoaId = codigo;
            
            //ViewData["Atributo"] = nomeFormCollection["id do Formulario"];
            //Tipo de parametros classe: FormCollection form 
                ViewData["Nome"] = form["nome"];
                ViewData["Email"] = form["email"];
                ViewData["PessoaId"] = form["codigo"];
            */

            //Essa Forma só funciona se a view que mandar os dados for tipada
            /*Tipo parametro objeto: Objeto nomeObjeto
            ViewData["a"] = pessoa.Nome;
            ViewData["s"] = pessoa.Email;
            ViewData["d"] = pessoa.PessoaId; */

            //Caso opite por enviar o objeto em si, deverar converte a view que o recebera a tipada
            return View(pessoa);

        }
    }
}