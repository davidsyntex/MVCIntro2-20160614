﻿using System.Web;
using System.Web.Mvc;

namespace MVCIntro2_20160614
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
