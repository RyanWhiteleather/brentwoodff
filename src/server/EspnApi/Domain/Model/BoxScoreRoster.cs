namespace EspnApi.Domain.Model;

public class BoxScoreRoster
{
    public int SeasonId { get; set; }
    public int ScoringPeriodId { get; set; }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string FullName { get; set; }
    public string LastName { get; set; }
    public string ProTeam { get; set; }
    public string ProTeamAbbreviation { get; set; }
    public string DefaultPosition { get; set; }
    public string[] EligiblePositions { get; set; }
    public string AvailabilityStatus { get; set; }
    public bool IsDroppable { get; set; }
    public bool IsInjured { get; set; }
    public string InjuryStatus { get; set; }
    public string RosteredPosition { get; set; }
    public double TotalPoints { get; set; }
    public PointBreakdown PointBreakdown { get; set; }
    public ProjectedPointBreakdown ProjectedPointBreakdown { get; set; }
    public RawStats RawStats { get; set; }
    public ProjectedRawStats ProjectedRawStats { get; set; }
}







