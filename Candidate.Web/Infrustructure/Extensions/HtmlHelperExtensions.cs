﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Candidate.Core.Extensions;

namespace Candidate.Infrustructure.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString CurrentAction(this HtmlHelper helper)
        {
            var action = helper.ViewContext.RouteData.GetRequiredString("action");
            return new MvcHtmlString(action.FirstCharIsUpperCase());
        }

        public static MvcHtmlString CurrentController(this HtmlHelper helper)
        {
            var controller = helper.ViewContext.RouteData.GetRequiredString("controller");
            return new MvcHtmlString(controller.FirstCharIsUpperCase());
        }
    }
}