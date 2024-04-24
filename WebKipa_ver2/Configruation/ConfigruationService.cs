using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace WebKipa_ver2.Configruation
{
    public class ConfigruationService
    {
        public static void RegisterGlobalizationAndLocalization(this IServiceCollection services)
        {
            var supportedCultures = new[]
   {
        new CultureInfo("vi-VI"),
                new CultureInfo("korea-KOREA"),
                // Add other cultures here
    };

            services.Configure<RequestLocalizationOptions>(options =>
            {

                options.DefaultRequestCulture = new RequestCulture("korea-KOREA");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
        }
    }
}
