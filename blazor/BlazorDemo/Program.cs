using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using BlazorDemo.Services;

namespace BlazorDemo
{
	public class Program
	{
		static void Main(string[] args)
		{
			var serviceProvider = new BrowserServiceProvider(services =>
			{
				// Add any custom services here
				services.AddScoped<ConferenceService>();
			});

			new BrowserRenderer(serviceProvider).AddComponent<App>("app");
		}
	}
}
