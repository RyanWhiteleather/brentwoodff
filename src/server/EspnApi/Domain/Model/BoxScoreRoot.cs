using System.Text.Json.Serialization;

namespace EspnApi.Domain.Model;

/// <summary>
/// Root class that holds Box score information for the week.
/// </summary>
public class BoxScoreRoot
{
    public BoxScoreTeam Away { get; set; }
    public BoxScoreTeam Home { get; set; }
    public string Winner { get; set; }
    public int Id { get; set; }
    public int MatchupPeriodId { get; set; }
    public string PlayoffTierType { get; set; }
}

public class BoxScoreTeam
{
    [JsonPropertyName("rosterForCurrentScoringPeriod")]
    public BoxScoreRoster Roster { get; set; }
    
    public int GamesPlayed { get; set; }
    
    public double TotalPoints { get; set; }
    
    public int TeamId { get; set; }
    
    public double Tiebreak { get; set; }
    
    
}