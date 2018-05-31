using System.Web;
using System.Web.Mvc;

namespace Projeto009_LayoutRander {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
