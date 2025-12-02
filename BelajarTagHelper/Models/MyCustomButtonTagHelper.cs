using Microsoft.AspNetCore.Razor.TagHelpers;
namespace BelajarTagHelper.Models
{
    [HtmlTargetElement("custom-button")]
    public class MyCustomButtonTagHelper : TagHelper
    {
        public string Text { get; set; } = "Click Me";

        public string ButtonType { get; set; } = "button";

        public string ButtonClass { get; set; } = "btn-primary";
    
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";

            output.Attributes.SetAttribute("type", ButtonType);

            output.Attributes.SetAttribute("class", $"btn {ButtonClass}");

            output.Content.SetContent(Text);
        }
    }
}