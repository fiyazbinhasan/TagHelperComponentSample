using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperComponentRazorPages.TagHelpers
{
	public class MarkupTagHelperComponent : ITagHelperComponent
    {
		private string _markup;
		private int _order;

		public MarkupTagHelperComponent(string markup, int order)
        {
			_markup = markup;
			_order = order;
        }

		public int Order => _order;

		public void Init(TagHelperContext context) { }

		public async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			if (string.Equals(context.TagName, "address", StringComparison.OrdinalIgnoreCase) && output.Attributes.ContainsName("printable"))
			{
				var content = await output.GetChildContentAsync();
				output.Content.SetHtmlContent($"{content}{_markup}");
			}
		}
	}
}
