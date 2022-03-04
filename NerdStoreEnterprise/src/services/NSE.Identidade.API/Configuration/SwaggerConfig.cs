﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace NSE.Identidade.API.Configuration {
	public static class SwaggerConfig {


		public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services) {

			services.AddSwaggerGen(c => {
				c.SwaggerDoc("v1", new OpenApiInfo {

					Title = "NerdStore Enterprise Identity API",
					Description = "Esta API faz parte do curso de ASP.NET Core Enterprise Applications.",
					Contact = new OpenApiContact() { Name = "Anderson", Email = "anderson.silvait@outlook.com" },
					License = new OpenApiLicense() { Name = "MIT", Url = new System.Uri("https://opensource.org/licenses/MIT") }
				});
			});

			return services;
		}

		public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app) {


			app.UseSwagger();
			app.UseSwaggerUI(c => {
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
			});
		}

	}
}
