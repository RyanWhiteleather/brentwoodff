using System.Text.Json.Serialization;

namespace EspnApi.Domain.Model;

/// <summary>
/// Root class that holds Box score information for the week.
/// </summary>
public class BoxScoreRoot
{
    public BoxScore Away { get; set; }
    public BoxScore Home { get; set; }
    public string Winner { get; set; }
}

public class BoxScore
{
    public BoxScoreRoster[] Roster { get; set; }
    
    [JsonPropertyName("totalPoints")]
    public double Score { get; set; }
    
    public int TeamId { get; set; }
    
}