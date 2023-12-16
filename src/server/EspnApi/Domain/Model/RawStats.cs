namespace EspnApi.Domain.Model;

public class RawStats
{
    public bool UsesPoints { get; set; }
    public int RushingAttempts { get; set; }
    public int RushingYards { get; set; }
    public int RushingYardsPer5Yards { get; set; }
    public int RushingYardsPer10Yards { get; set; }
    public int RushingYardsPer20Yards { get; set; }
    public int RushingYardsPer25Yards { get; set; }
    public int RushingYardsPer50Yards { get; set; }
    public int RushingAttemptsPer5Attempts { get; set; }
    public int RushingAttemptsPer10Attempts { get; set; }
    public double RushingYardsPerAttempt { get; set; }
    public int ReceivingYards { get; set; }
    public int ReceivingYardsPer5Yards { get; set; }
    public int ReceivingYardsPer10Yards { get; set; }
    public int ReceivingYardsPer20Yards { get; set; }
    public int ReceivingYardsPer25Yards { get; set; }
    public int ReceivingReceptions { get; set; }
    public int ReceivingTargets { get; set; }
    public int ReceivingYardsAfterCatch { get; set; }
    public double ReceivingYardsPerReception { get; set; }
    public int TeamWin { get; set; }
}