﻿using System.Web;
using System.Web.Mvc;

namespace BG_UI_deneme1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}