using Projeto007_RotasMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Projeto007_RotasMVC.Controllers {
    public class HomeController : Controller {


        
        private readonly IEnumerable<Noticia> todasAsNoticias; //Cria um IEnumerable
        public HomeController() { //Construtor
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);//Instancia método TodasAsNoticias e ordena por data em todasAsNoticias
        }




        public ActionResult Index() {

            var ultimasNoticias = todasAsNoticias.Take(3); // Variável recebe de todasAsNoticias as tres ultimas noticias
            var todasAsCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();// Recebe todas as categorias sem deixar repetir e conver para lista

            ViewBag.Categorias = todasAsCategorias;
            return View(ultimasNoticias);
        }



        public ActionResult TodasAsNoticias() {
            return View(todasAsNoticias);
        }




        public ActionResult MostraNoticia(int noticiaId, string categoria, string titulo) {
            return View(todasAsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
        }



        public ActionResult MostraCategoria(string categoria) {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }


    }
}