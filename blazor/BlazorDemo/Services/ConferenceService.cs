using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorDemo.Pages;
using Microsoft.AspNetCore.Blazor;

namespace BlazorDemo.Services
{
	public class ConferenceService
	{
		private readonly HttpClient _httpClient;

		public ConferenceService(HttpClient httpClient)
		{
			_httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
		}

		public async Task<IEnumerable<ConferenceModel>> LoadConferences()
		{
			var data = await _httpClient.GetJsonAsync<Conference[]>("https://ttconferences.azurewebsites.net/events/list");

			return data.Select(c => new ConferenceModel()
				{
					Date = c.date,
					Name = c.name,
					Link = c.link,
					Location = c.location,
				})
				.Where(c => c.Date > DateTime.Today.AddDays(-3))
				.OrderBy(c => c.Date)
				.ThenBy(c => c.Name)
				.ToList();
		}

		private class Conference
		{
			public DateTime date { get; set; }
			public string link { get; set; }
			public string name { get; set; }
			public string location { get; set; }
		}
	}
}
