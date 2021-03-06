﻿using System.IO;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;

namespace FilterLists.Api.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddFilterListsApi(this IServiceCollection services)
        {
            services.AddMvc();
            services.AddApiVersioning();
            services.AddSwaggerGenCustom();
            TelemetryDebugWriter.IsTracingDisabled = true;
        }

        private static void AddSwaggerGenCustom(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "FilterLists API",
                        Version = "v1",
                        Description =
                            "FilterLists is the independent and comprehensive directory of all public filter and hosts lists for advertisements, trackers, malware, and annoyances.",
                        Contact = new Contact {Url = "https://github.com/collinbarrett/FilterLists/issues"},
                        License = new License
                        {
                            Name = "Use under MIT License",
                            Url = "https://github.com/collinbarrett/FilterLists/blob/master/LICENSE"
                        }
                    });
                c.IncludeXmlComments(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath,
                    "FilterLists.Api.xml"));
            });
        }
    }
}