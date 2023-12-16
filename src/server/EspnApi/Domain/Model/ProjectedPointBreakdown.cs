namespace EspnApi.Domain.Model;

public class ProjectedPointBreakdown
{
    public bool UsesPoints { get; set; }
    public double RushingYards { get; set; }
    public double RushingTouchdowns { get; set; }
    public double Rushing2PtConversions { get; set; }
    public double ReceivingYards { get; set; }
    public double ReceivingTouchdowns { get; set; }
    public double Receiving2PtConversions { get; set; }
    public double ReceivingReceptions { get; set; }
    public double LostFumbles { get; set; }
}