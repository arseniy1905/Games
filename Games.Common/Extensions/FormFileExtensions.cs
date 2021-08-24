using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Games.Common.Extensions
{
    public static class FormFileExtensions
    {
        public static string ToBase64String(this IFormFile fileContent)
        {
            if (fileContent == null)
            {
                return string.Empty;
            }

            MemoryStream ms = new MemoryStream();
            fileContent.CopyTo(ms);
            return Convert.ToBase64String(ms.ToArray());
        }
    }
}
