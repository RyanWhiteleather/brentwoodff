using Newtonsoft.Json;

namespace EspnApi.Domain.Model;

public class League
{
    [JsonProperty("settings")]
    public LeagueSettings LeagueSettings { get; set; }
        
    [JsonProperty("status")]
    public LeagueStatus LeagueStatus { get; set; }
}