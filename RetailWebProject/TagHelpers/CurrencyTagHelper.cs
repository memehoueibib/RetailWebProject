using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Globalization;

namespace RetailWebProject.TagHelpers
{
    [HtmlTargetElement("currency")]
    public class CurrencyTagHelper : TagHelper
    {
        public decimal Amount { get; set; }
        public string? CurrencyCode { get; set; } = "USD";
        public bool ShowSymbol { get; set; } = true;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.Attributes.SetAttribute("class", "currency-amount");

            string formattedAmount;
            
            if (ShowSymbol)
            {
                formattedAmount = Amount.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            }
            else
            {
                formattedAmount = Amount.ToString("N2", CultureInfo.GetCultureInfo("en-US"));
                if (!string.IsNullOrEmpty(CurrencyCode))
                {
                    formattedAmount += $" {CurrencyCode}";
                }
            }

            output.Content.SetContent(formattedAmount);

            // Add styling for better visual appeal
            if (Amount > 500)
            {
                output.Attributes.SetAttribute("class", "currency-amount text-success fw-bold");
            }
            else if (Amount > 100)
            {
                output.Attributes.SetAttribute("class", "currency-amount text-primary");
            }
            else
            {
                output.Attributes.SetAttribute("class", "currency-amount text-muted");
            }
        }
    }
}