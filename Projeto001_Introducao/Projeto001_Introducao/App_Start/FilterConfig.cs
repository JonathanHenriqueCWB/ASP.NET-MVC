﻿using System.Web;
using System.Web.Mvc;

namespace Projeto001_Introducao
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
