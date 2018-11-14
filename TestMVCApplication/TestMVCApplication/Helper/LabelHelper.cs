using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVCApplication.Helper
{
    public static class LabelHelper
    {
        public static string Label(this HtmlHelper helper, string target, string text, int num)
        {
            string s = $"<label for = {target}>{text}</label>";
            return s;
        }
    }
}