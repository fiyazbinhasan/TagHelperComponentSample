using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace TagHelperComponentRazorPages.TagHelpers
{
	[HtmlTargetElement("address")]
    [EditorBrowsable(EditorBrowsableState.Never)]
	public class AddressTagHelperComponentTagHelper : TagHelperComponentTagHelper
    {
		public AddressTagHelperComponentTagHelper(ITagHelperComponentManager componentManager, ILoggerFactory loggerFactory)
            : base(componentManager, loggerFactory)
        {
        }
    }
}
