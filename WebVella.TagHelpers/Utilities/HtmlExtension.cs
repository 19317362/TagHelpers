﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Web.Mvc
{
	public static class WvTaghelperExtension
	{
		public static IHtmlContent WvRaw(this IHtmlHelper helper, string input){
			
			return new HtmlString( helper.Raw(input).ToString().Replace("</script>","</s\\cript>"));
		}
	}
}
