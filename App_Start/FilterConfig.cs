﻿using System.Web;
using System.Web.Mvc;

namespace Capstone2019EMO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
