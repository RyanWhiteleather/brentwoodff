using System.Text.Json.Serialization;

namespace EspnApi.Domain.Model;

/// <summary>
/// TODO: Come up with a better name for this class.
/// </summary>
public class PlayerEntry
{
    /// <summary>
    /// The actual points this player scored.
    /// </summary>
    public double AppliedStatTotal { get; set; }
    
    [JsonPropertyName("player")]
    public BoxScorePlayer BoxScorePlayer { get; set; }
}