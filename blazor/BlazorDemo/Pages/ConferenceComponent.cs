using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Services;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorDemo.Pages
{
	public class ConferenceComponent : BlazorComponent
	{
		[Inject]
		private ConferenceService _conferenceService { get; set; }

		protected IEnumerable<ConferenceModel> Conferences { get; private set; }

		protected override async Task OnInitAsync()
		{
			Conferences = await _conferenceService.LoadConferences();
		}
	}
}
