using System;
using Microsoft.AspNetCore.Builder;

namespace Wimm.API.Core.DependencyInjection
{
    public static class AppBuilderCollectionExtensions
    {
        public static void UseSwaggerServices(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WIMM API - v1.0");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
