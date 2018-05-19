using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperComponentRazorPages.TagHelpers
{
	public class ScriptTagHelperComponent : ITagHelperComponent
    {      
		public int Order => 2;

		public void Init(TagHelperContext context) { }

		public async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			if (string.Equals(context.TagName, "body", StringComparison.OrdinalIgnoreCase)) 
			{
				var script = await File.ReadAllTextAsync("Files/AddressToolTipScript.html");
				output.PostContent.AppendHtml(script);
			}
		}
	}
}
