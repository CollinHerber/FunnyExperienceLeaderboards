using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace FunnyExperience.Commands
{
	[Autoload]
	public class TestCommand : ModCommand
	{
		public override string Command => "test";
		private readonly JsonSerializerSettings _jsonSerializerSettings = Constants.Json.SnakeCaseSerializerSettings;

		public override CommandType Type => CommandType.Chat;

		public override string Usage => "[c/ff6a00:Usage: /stats]";

		public override string Description => "Post Current Stats";

		public override void Action(CommandCaller caller, string input, string[] args)
		{
			if (args.Length > 0)
			{
				caller.Reply("Command expected no arguments", Color.Red);
				return;
			}

			PostStats();
		}

		private void PostStats()
		{
			//This will freeze the client. Prompt message before hand?
			using var client = new HttpClient();
			HttpResponseMessage response = client.PostAsync(
				"http://localhost:5000/Player/Stats",
				CreateRequestObject(new UpdateLevelRequest { PlayerName = "Collin", Level = 1 })).Result;
			if (!response.IsSuccessStatusCode) return; // Handle error?
			string body = response.Content.ReadAsStringAsync().Result; //Do something with success?
		}

		private StringContent CreateRequestObject(dynamic obj)
		{
			dynamic json = JsonConvert.SerializeObject(obj, _jsonSerializerSettings);
			return new StringContent(json, Encoding.UTF8, "application/json");
		}

		private class UpdateLevelRequest
		{
			public string PlayerName { get; set; }
			public int Level { get; set; }
		}
	}
}