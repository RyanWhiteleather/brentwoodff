using System.Text.Json.Serialization;

namespace EspnApi.Domain.Model;

public class RosterEntries
{
    public string InjuryStatus { get; set; }
    public int LineupSlotId { get; set; }
    
    /// <summary>
    /// The ID of the player, I may be able to use this to look up more player information.
    /// </summary>
    public int PlayerId { get; set; }
    
    [JsonPropertyName("playerPoolEntry")]
    public PlayerEntry PlayerEntry { get; set; }
    public string Status { get; set; }
}