using System.Text.Json.Serialization;

namespace EspnApi.Domain.Model;

/// <summary>
/// This class is stored as an array on the BoxScorePlayer class when deserializing the JSON.
///
/// I think we only care about the element in the array where StatSourceId = 1 and StatSplitTypeId = 1.
/// I do not know what those actually mean.
/// </summary>
public class BoxScorePlayerStats
{
    /// <summary>
    /// The stat breakdown of what was applied to the Player.
    /// </summary>
    public ScoringStats AppliedStats { get; set; }
    public double AppliedTotal { get; set; }
    public string ExternalId { get; set; }
    public string Id { get; set; }
    public int ProTeamId { get; set; }
    public int ScoringPeriodId { get; set; }
    public int SeasonId { get; set; }
    public int StatSourceId { get; set; }
    public int StatSplitTypeId { get; set; }
}