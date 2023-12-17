using System.Text.Json.Serialization;

namespace EspnApi.Domain.Model;

/// <summary>
/// The actual stats that were applied to a player.
/// </summary>
public class ScoringStats
{
    
    [JsonPropertyName("0")]
    public double PassingAttempts { get; set; }
    [JsonPropertyName("1")]
    public double PassingCompletions { get; set; } 
    [JsonPropertyName("2")]
    public double PassingIncompletions { get; set; } 
    [JsonPropertyName("3")]
    public double PassingYards { get; set; } 
    [JsonPropertyName("4")]
    public double PassingTouchdowns { get; set; } 
    [JsonPropertyName("5")]
    public double PassingYardsPer5Yards { get; set; } 
    [JsonPropertyName("6")]
    public double PassingYardsPer10Yards { get; set; } 
    [JsonPropertyName("7")]
    public double PassingYardsPer20Yards { get; set; } 
    [JsonPropertyName("8")]
    public double PassingYardsPer25Yards { get; set; } 
    [JsonPropertyName("9")]
    public double PassingYardsPer50Yards { get; set; } 
    [JsonPropertyName("10")]
    public double PassingYardsPer100Yards { get; set; } 
    
    
    [JsonPropertyName("11")]
    public double PassingCompletionsPer5Completions { get; set; } 
    [JsonPropertyName("12")]
    public double PassingCompletionsPer10Completions { get; set; } 
    [JsonPropertyName("13")]    
    public double PassingIncompletionsPer5Incompletions { get; set; } 
    [JsonPropertyName("14")] 
    public double PassingIncompletionsPer10Incompletions { get; set; } 

    [JsonPropertyName("15")]
    public double PassingTouchdowns40Plus { get; set; } 
    [JsonPropertyName("16")]
    public double PassingTouchdowns50Plus { get; set; }

    [JsonPropertyName("17")]
    public double PassingYards300To399 { get; set; } 
    [JsonPropertyName("18")]
    public double PassingYards400Plus { get; set; } 
    

    [JsonPropertyName("19")]
    public double Passing2PtConversions { get; set; } 
    [JsonPropertyName("20")]
    public double PassingInterceptions { get; set; } 
    [JsonPropertyName("21")]
    public double PassingCompletionPercentage { get; set; } 

    
    [JsonPropertyName("23")]
    public double RushingAttempts { get; set; } 
    [JsonPropertyName("24")]
    public double RushingYards { get; set; }
    [JsonPropertyName("25")]
    public double RushingTouchdowns { get; set; } 
    [JsonPropertyName("26")]
    public double Rushing2PtConversions { get; set; } 

    [JsonPropertyName("27")]
    public double RushingYardsPer5Yards { get; set; } 
    [JsonPropertyName("28")]
    public double RushingYardsPer10Yards { get; set; } 
    [JsonPropertyName("29")]
    public double RushingYardsPer20Yards { get; set; } 
    [JsonPropertyName("30")]
    public double RushingYardsPer25Yards { get; set; } 
    [JsonPropertyName("31")]
    public double RushingYardsPer50Yards { get; set; } 
    [JsonPropertyName("32")]
    public double RushingYardsPer100Yards { get; set; } 
    
    [JsonPropertyName("33")]
    public double RushingAttemptsPer5Attempts { get; set; } 
    [JsonPropertyName("34")]
    public double RushingAttemptsPer10Attempts { get; set; } 

    [JsonPropertyName("35")]
    public double RushingTouchdowns40Plus { get; set; } 
    [JsonPropertyName("36")]
    public double RushingTouchdowns50Plus { get; set; } 

    [JsonPropertyName("37")]
    public double RushingGame100To199Yards { get; set; } 
    [JsonPropertyName("38")]
    public double RushingGame200PlusYards { get; set; } 

    [JsonPropertyName("39")]
    public double RushingYardsPerAttempt { get; set; } 

    // 41 is a legacy id for receptions?
    [JsonPropertyName("42")]
    public double ReceivingYards { get; set; } 
    [JsonPropertyName("43")]
    public double ReceivingTouchdowns { get; set; }
    [JsonPropertyName("44")]
    public double Receiving2PtConversions { get; set; }
    [JsonPropertyName("45")]
    public double ReceivingTouchdowns40Plus { get; set; } 
    [JsonPropertyName("46")]
    public double ReceivingTouchdowns50Plus { get; set; } 

    [JsonPropertyName("47")]
    public double ReceivingYardsPer5Yards { get; set; } 
    [JsonPropertyName("48")]
    public double ReceivingYardsPer10Yards { get; set; } 
    [JsonPropertyName("49")]
    public double ReceivingYardsPer20Yards { get; set; } 
    [JsonPropertyName("50")]
    public double ReceivingYardsPer25Yards { get; set; } 
    [JsonPropertyName("51")]
    public double ReceivingYardsPer50Yards { get; set; } 
    [JsonPropertyName("52")]
    public double ReceivingYardsPer100Yards { get; set; } 
    
    [JsonPropertyName("53")]
    public double ReceivingReceptions { get; set; } 
    [JsonPropertyName("54")]
    public double ReceptionsPer5Receptions { get; set; }
    [JsonPropertyName("55")]
    public double ReceptionsPer10Receptions { get; set; } 
    
    [JsonPropertyName("56")]
    public double ReceivingTouchdowns40Plus56 { get; set; } 
    [JsonPropertyName("57")]
    public double ReceivingTouchdowns50Plus57 { get; set; } 
    
    [JsonPropertyName("58")]
    public double ReceivingTargets { get; set; } 
    [JsonPropertyName("59")]
    public double ReceivingYardsAfterCatch { get; set; }
    [JsonPropertyName("60")]
    public double ReceivingYardsPerReception { get; set; } 

    [JsonPropertyName("68")]
    public double Fumbles { get; set; } 
    [JsonPropertyName("72")]
    public double LostFumbles { get; set; } 
    [JsonPropertyName("73")]
    public double TotalTurnovers { get; set; }

    [JsonPropertyName("201")]
    public double MadeFieldGoalsFrom60Plus { get; set; } 
    [JsonPropertyName("202")]
    public double AttemptedFieldGoalsFrom60Plus { get; set; } 
    [JsonPropertyName("203")]
    public double MissedFieldGoalsFrom60Plus { get; set; } 
    
    [JsonPropertyName("74")]
    public double MadeFieldGoalsFrom50Plus { get; set; } 
    [JsonPropertyName("75")]
    public double AttemptedFieldGoalsFrom50Plus { get; set; } 
    [JsonPropertyName("76")]
    public double MissedFieldGoalsFrom50Plus { get; set; } 

    [JsonPropertyName("198")]
    public double MadeFieldGoalsFrom50To59 { get; set; } 
    [JsonPropertyName("199")]
    public double AttemptedFieldGoalsFrom50To59 { get; set; } 
    [JsonPropertyName("200")]
    public double MissedFieldGoalsFrom50To59 { get; set; } 
    
    [JsonPropertyName("77")]
    public double MadeFieldGoalsFrom40To49 { get; set; }
    [JsonPropertyName("78")]
    public double AttemptedFieldGoalsFrom40To49 { get; set; } 
    [JsonPropertyName("79")]
    public double MissedFieldGoalsFrom40To49 { get; set; } 

    [JsonPropertyName("80")]
    public double MadeFieldGoalsFromUnder40 { get; set; } 
    [JsonPropertyName("81")]
    public double AttemptFieldGoalsFromUnder40 { get; set; } 
    [JsonPropertyName("82")]
    public double MissedFieldGoalsFromUnder40 { get; set; } 

    [JsonPropertyName("83")]
    public double MadeFieldGoals { get; set; } 
    [JsonPropertyName("84")]
    public double AttemptedFieldGoals { get; set; } 
    [JsonPropertyName("85")]
    public double MissedFieldGoals { get; set; } 

    [JsonPropertyName("214")]
    public double FieldGoalMadeYards { get; set; } 
    [JsonPropertyName("217")]
    public double FieldGoalMadeYardsPer5Yards { get; set; } 
    [JsonPropertyName("218")]
    public double FieldGoalMadeYardsPer10Yards { get; set; } 
    [JsonPropertyName("219")]
    public double FieldGoalMadeYardsPer20Yards { get; set; } 
    [JsonPropertyName("220")]
    public double FieldGoalMadeYardsPer25Yards { get; set; } 
    [JsonPropertyName("221")]
    public double FieldGoalMadeYardsPer50Yards { get; set; }
    [JsonPropertyName("222")]
    public double FieldGoalMadeYardsPer100Yards { get; set; } 
    [JsonPropertyName("215")]
    public double FieldGoalMissedYards { get; set; } 
    [JsonPropertyName("223")]
    public double FieldGoalMissedYardsPer5Yards { get; set; } 
    [JsonPropertyName("224")]
    public double FieldGoalMissedYardsPer10Yards { get; set; } 
    [JsonPropertyName("225")]
    public double FieldGoalMissedYardsPer20Yards { get; set; } 
    [JsonPropertyName("226")]
    public double FieldGoalMissedYardsPer25Yards { get; set; } 
    [JsonPropertyName("227")]
    public double FieldGoalMissedYardsPer50Yards { get; set; } 
    [JsonPropertyName("228")]
    public double FieldGoalMissedYardsPer100Yards { get; set; } 
    [JsonPropertyName("216")]
    public double FieldGoalAttemptedYards { get; set; } 
    [JsonPropertyName("229")]
    public double FieldGoalAttemptedYardsPer5Yards { get; set; } 
    [JsonPropertyName("230")]
    public double FieldGoalAttemptedYardsPer10Yards { get; set; } 
    [JsonPropertyName("231")]
    public double FieldGoalAttemptedYardsPer20Yards { get; set; } 
    [JsonPropertyName("232")]
    public double FieldGoalAttemptedYardsPer25Yards { get; set; } 
    [JsonPropertyName("233")]
    public double FieldGoalAttemptedYardsPer50Yards { get; set; } 
    [JsonPropertyName("234")]
    public double FieldGoalAttemptedYardsPer100Yards { get; set; } 
    
    [JsonPropertyName("86")]
    public double MadeExtraPoints { get; set; } 
    [JsonPropertyName("87")]
    public double AttemptedExtraPoints { get; set; } 
    [JsonPropertyName("88")]
    public double MissedExtraPoints { get; set; } 

    [JsonPropertyName("93")]
    public double DefensiveBlockedKickForTouchdowns { get; set; } 
    [JsonPropertyName("95")]
    public double DefensiveInterceptions { get; set; }
    [JsonPropertyName("96")]
    public double DefensiveFumbles { get; set; } 
    [JsonPropertyName("97")]
    public double DefensiveBlockedKicks { get; set; } 
    [JsonPropertyName("98")]
    public double DefensiveSafeties { get; set; } 
    [JsonPropertyName("99")]
    public double DefensiveSacks { get; set; } 
    [JsonPropertyName("100")]
    public double DefensiveHalfSacks { get; set; } 

    [JsonPropertyName("101")]
    public double KickoffReturnTouchdown { get; set; } 
    [JsonPropertyName("102")]
    public double PuntReturnTouchdown { get; set; } 
    [JsonPropertyName("103")]
    public double FumbleReturnTouchdown { get; set; } 
    [JsonPropertyName("104")]
    public double InterceptionReturnTouchdown { get; set; } 
    [JsonPropertyName("105")]
    public double TotalReturnTouchdowns { get; set; } 

    [JsonPropertyName("106")]
    public double DefensiveForcedFumbles { get; set; } 
    [JsonPropertyName("107")]
    public double DefensiveAssistedTackles { get; set; } 
    [JsonPropertyName("108")]
    public double DefensiveSoloTackles { get; set; } 
    [JsonPropertyName("109")]
    public double DefensiveTotalTackles { get; set; } 
        [JsonPropertyName("110")]
    public double DefensiveTacklesPer3Tackles { get; set; } 
        [JsonPropertyName("111")]
    public double DefensiveTacklesPer5Tackles { get; set; } 
    [JsonPropertyName("112")]
    public double DefensiveStuffs { get; set; } 

    [JsonPropertyName("114")]
    public double KickoffReturnYards { get; set; } 
    [JsonPropertyName("115")]
    public double PuntReturnYards { get; set; } 

    [JsonPropertyName("120")]
    public double DefensivePointsAllowed { get; set; } 
    [JsonPropertyName("89")]
    public double Defensive0PointsAllowed { get; set; } 
    [JsonPropertyName("90")]
    public double Defensive1To6PointsAllowed { get; set; } 
    [JsonPropertyName("91")]
    public double Defensive7To13PointsAllowed { get; set; } 
    [JsonPropertyName("92")]
    public double Defensive14To17PointsAllowed { get; set; } 
    [JsonPropertyName("121")]
    public double Defensive18To21PointsAllowed { get; set; } 
    [JsonPropertyName("122")]
    public double Defensive22To27PointsAllowed { get; set; } 
    [JsonPropertyName("123")]
    public double Defensive28To34PointsAllowed { get; set; } 
    [JsonPropertyName("124")]
    public double Defensive35To45PointsAllowed { get; set; } 
    [JsonPropertyName("125")]
    public double DefensiveOver45PointsAllowed { get; set; } 

    [JsonPropertyName("127")]
    public double DefensiveYardsAllowed { get; set; } 
    [JsonPropertyName("128")]
    public double DefensiveLessThan100YardsAllowed { get; set; } 
    [JsonPropertyName("129")]
    public double Defensive100To199YardsAllowed { get; set; } 
    [JsonPropertyName("130")]
    public double Defensive200To299YardsAllowed { get; set; } 
    [JsonPropertyName("132")]
    public double Defensive350To399YardsAllowed { get; set; } 
    [JsonPropertyName("133")]
    public double Defensive400To449YardsAllowed { get; set; } 
    [JsonPropertyName("134")]
    public double Defensive450To499YardsAllowed { get; set; } 
    [JsonPropertyName("135")]
    public double Defensive500To549YardsAllowed { get; set; } 
    [JsonPropertyName("136")]
    public double DefensiveOver550YardsAllowed { get; set; } 

    [JsonPropertyName("138")]
    public double NetPunts { get; set; } 
    [JsonPropertyName("139")]
    public double PuntYards { get; set; } 
    [JsonPropertyName("140")]
    public double PuntsInsideThe10 { get; set; } 
    [JsonPropertyName("141")]
    public double PuntsInsideThe20 { get; set; } 
    [JsonPropertyName("146")]
    public double FairCatches { get; set; } 

    [JsonPropertyName("155")]
    public double TeamWin { get; set; } 
    [JsonPropertyName("156")]
    public double TeamLoss { get; set; } 
    [JsonPropertyName("157")]
    public double TeamTie { get; set; } 
    [JsonPropertyName("158")]
    public double TeamPointsScored { get; set; } 

    [JsonPropertyName("161")]
    public double TeamWinMargin25Plus { get; set; } 
    [JsonPropertyName("162")]
    public double TeamWinMargin20To24 { get; set; } 
    [JsonPropertyName("163")]
    public double TeamWinMargin15To19 { get; set; } 
    [JsonPropertyName("164")]
    public double TeamWinMargin10To14 { get; set; } 
    [JsonPropertyName("165")]
    public double TeamWinMargin5To9 { get; set; } 
    [JsonPropertyName("166")]
    public double TeamWinMargin1To4 { get; set; } 
    [JsonPropertyName("172")]
    public double TeamLossMargin25Plus { get; set; } 
    [JsonPropertyName("171")]
    public double TeamLossMargin20To24 { get; set; } 
    [JsonPropertyName("170")]
    public double TeamLossMargin15To19 { get; set; } 
    [JsonPropertyName("169")]
    public double TeamLossMargin10To14 { get; set; } 
    [JsonPropertyName("168")]
    public double TeamLossMargin5To9 { get; set; } 
    [JsonPropertyName("167")]
    public double TeamLossMargin1To4 { get; set; } 
}