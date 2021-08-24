using Microsoft.AspNetCore.Html;
using System.IO;

namespace Games.Common.Extensions
{
    public static class HTMLContentExtensions
    {
        public static string ToHtmlString(this IHtmlContent htmlContent)
        {
            if (htmlContent is HtmlString htmlString)
            {
                return htmlString.Value;
            }

            using var writer = new StringWriter();
            htmlContent.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
            return writer.ToString();
        }
    }
}
