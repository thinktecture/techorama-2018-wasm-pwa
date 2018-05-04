using System;

namespace BlazorDemo.Pages
{
	public class ConferenceModel
	{
		public DateTime Date { get; set; }
		public string Link { get; set; }
		public string Location { get; set; }
		public string Name { get; set; }
		public bool Favorite { get; set; }
	}
}