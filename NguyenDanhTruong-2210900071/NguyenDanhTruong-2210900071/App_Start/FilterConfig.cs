﻿using System.Web;
using System.Web.Mvc;

namespace NguyenDanhTruong_2210900071
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}