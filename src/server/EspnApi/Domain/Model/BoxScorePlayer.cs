using System.Text.Json.Serialization;

namespace EspnApi.Domain.Model;

/// <summary>
/// Contains player information for a matchup period.
/// </summary>
public class BoxScorePlayer
{
    public bool Active { get; set; }
    public int DefaultPositionId { get; set; }
    public bool Droppable { get; set; }
    
    /// <summary>
    /// ex. [2, 3, 23, 7, 20, 21]
    /// TODO: Need to create something to convert these values to the actual positions.
    /// </summary>
    public int[] EligibleSlots { get; set; }
    public string FirstName { get; set; }
    public string FullName { get; set; }
    public int Id { get; set; }
    public bool Injured { get; set; }
    public string InjuryStatus { get; set; }
    public string LastName { get; set; }
    public int ProTeamId { get; set; }
    public BoxScorePlayerStats[] Stats { get; set; }
}