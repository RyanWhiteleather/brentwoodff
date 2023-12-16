namespace EspnApi.Domain.Model;

public class ProjectedRawStats
{
    public bool UsesPoints { get; set; }
    public double RushingAttempts { get; set; }
    public double RushingYards { get; set; }
    public double RushingTouchdowns { get; set; }
    public double Rushing2PtConversions { get; set; }
    public int RushingYardsPer5Yards { get; set; }
    public int RushingYardsPer10Yards { get; set; }
    public int RushingYardsPer20Yards { get; set; }
    public int RushingYardsPer25Yards { get; set; }
    public int RushingYardsPer50Yards { get; set; }
    public int RushingAttemptsPer5Attempts { get; set; }
    public int RushingAttemptsPer10Attempts { get; set; }
    public double RushingTouchdowns40Plus { get; set; }
    public double RushingTouchdowns50Plus { get; set; }
    public double RushingGame100To199Yards { get; set; }
    public double RushingGame200PlusYards { get; set; }
    public double RushingYardsPerAttempt { get; set; }
    public double ReceivingYards { get; set; }
    public double ReceivingTouchdowns { get; set; }
    public double Receiving2PtConversions { get; set; }
    public double ReceivingTouchdowns40Plus { get; set; }
    public double ReceivingTouchdowns50Plus { get; set; }
    public int ReceivingYardsPer5Yards { get; set; }
    public int ReceivingYardsPer10Yards { get; set; }
    public int ReceivingYardsPer20Yards { get; set; }
    public int ReceivingYardsPer25Yards { get; set; }
    public double ReceivingReceptions { get; set; }
    public double ReceivingTargets { get; set; }
    public double ReceivingYardsPerReception { get; set; }
    public double Fumbles { get; set; }
    public double LostFumbles { get; set; }
    public double TotalTurnovers { get; set; }
}