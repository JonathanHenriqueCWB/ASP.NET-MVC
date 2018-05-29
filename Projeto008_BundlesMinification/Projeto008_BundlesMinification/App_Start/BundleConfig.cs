using System.Web;
using System.Web.Optimization;

namespace Projeto008_BundlesMinification {
    public class BundleConfig {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {




            //Habilita o Optimization (minification)
            BundleTable.EnableOptimizations = true;

            /*
                //Exemplo de como excluir (Ignorar) um arquivo
                //bundles.IgnoreList.Ignore("*.dbg.js");
     
                //Cria um Bundle chamado comum, vai ate a pasta Scripts/comum e adiciona todos arquivos que terminam com js

                bundles.Add(new ScriptBundle("~/comum")
                    .IncludeDirectory("~/Scripts/comum" , "*.js", true));
                //Ordenando de maneira correta

                var ordem = new BundleFileSetOrdering("meuNome");
                ordem.Files.Add("setup.js");
                ordem.Files.Add("display.js");
                bundles.FileSetOrderList.Insert(0, ordem);
            */

            bundles.Add(new ScriptBundle("~/bundles/comum")
                .Include("~/Script/comum/*.js"));




            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
