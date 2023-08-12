using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cowbot.Server.ThirdPartyServices.DiscordApi;

public class DiscordGuildClient
{
    private readonly HttpClient _httpClient;

    public DiscordGuildClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> GetGuild(string guildId)
    {
	    using (HttpClient client = new HttpClient())
	    {
		    var response = await _httpClient.GetAsync("http://localhost:5000/Discord/Test");
		    var body = await response.Content.ReadAsStringAsync();
		    var result = JsonConvert.DeserializeObject<bool>(body);
		    return result;
	    }
    }
}