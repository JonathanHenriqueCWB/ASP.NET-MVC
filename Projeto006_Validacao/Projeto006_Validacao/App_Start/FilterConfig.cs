﻿using System.Web;
using System.Web.Mvc;

namespace Projeto006_Validacao
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
