using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestMVCApplication.Helper
{
    public static class ImageHelper
    {
        public static string Image(this HtmlHelper helper, string id, string url, string altText, int height, int width)
        {
            return Image(helper, id, url, altText, null,height, width);
        }

        public static string Image(this HtmlHelper helper, string id, string url, string altText, object htmlAttr, int height, int width)
        {
            var builder = new TagBuilder("img");
            builder.GenerateId(id);
            builder.MergeAttribute("src", url);
            builder.MergeAttribute("alt", altText);
            builder.MergeAttribute("height", height.ToString());
            builder.MergeAttribute("width", width.ToString());
            builder.MergeAttributes(new RouteValueDictionary(htmlAttr));
            string s = builder.ToString(TagRenderMode.SelfClosing);
            return s;
        }
    }
}