using System.Text.Json.Serialization;

namespace EspnApi.Domain.Model;

public class League
{
    [JsonPropertyName("settings")]
    public LeagueSettings LeagueSettings { get; set; }
        
    [JsonPropertyName("status")]
    public LeagueStatus LeagueStatus { get; set; }
}