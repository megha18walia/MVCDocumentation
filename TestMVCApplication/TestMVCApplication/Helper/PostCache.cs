using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVCApplication.Helper
{
    public static class PostCache
    {
        public static string RenderUpdatedCache(HttpContext context)
        {
            return DateTime.Now.ToString();
        }
    }
}