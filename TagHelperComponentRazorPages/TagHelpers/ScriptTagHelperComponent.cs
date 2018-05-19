using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperComponentRazorPages.TagHelpers
{
	public class ScriptTagHelperComponent : ITagHelperComponent
    {      
		private string _script = "<script>$('address').hover(function(){" +
			"$('address[printable]').attr({" +
			"'data-toggle' : 'tooltip', " +
			"'data-placement': 'right', " +
			"'title': 'Click on the icon button to get google map direction'});})</script>";

		public ScriptTagHelperComponent()
        {
			
        }

		public int Order => 3;

		public void Init(TagHelperContext context) { }

		public Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			if (string.Equals(context.TagName, "body", StringComparison.OrdinalIgnoreCase)) 
			{
				output.PostContent.AppendHtml(_script);
			}

			return Task.FromResult(0);
		}
	}
}
