using System;
using System.Linq;
using System.Web.Mvc;

namespace AcurenzAppFramework
{
    // See https://gist.github.com/jbogard/6812184
    public class AcurenzViewEngine : RazorViewEngine
    {
        public AcurenzViewEngine()
        {
            ViewLocationFormats = new[]
            {
                "~/Areas/Default/{1}/{0}.cshtml",
                "~/Areas/Default/Shared/{0}.cshtml"
            };

            MasterLocationFormats = ViewLocationFormats;
            PartialViewLocationFormats = ViewLocationFormats;
        }
    }
}