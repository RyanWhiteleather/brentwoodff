using System.Text.Json;
using EspnApi.Domain.Model;
using EspnApi.Domain.Provider;
using EspnApi.Domain.Extensions;

namespace EspnApi.Domain.Service;

/// <summary>
/// Service that handles call the to the ESPN V3 Fantasy Football API.
/// Currently this is only setup to be used with private leagues.
/// </summary>
/// <param name="leagueId"></param>
/// <param name="swid"></param>
/// <param name="espnS2"></param>
public class EspnApiService(int leagueId, string swid, string espnS2) : IEspnApiService
{
    private readonly HttpProvider _httpProvider = new(swid, espnS2 );
    
    /// <summary>
    /// Returns ESPN fantasy football league data. 
    /// </summary>
    /// <param name="seasonId">The year the season took place</param>
    /// <returns></returns>
    public Task<League> GetLeagueBySeasonAsync(int seasonId)
    {
        var url = new Route(
                $"{seasonId}/segments/0/leagues/{leagueId}", 
                "?view=mSettings")
            .ToString();
        return _httpProvider.GetAsync<League>(url);
    }

    /// <summary>
    /// Returns the boxscores for a week.
    ///
    /// The ESPN Api is wierd and will return all scoring periods and matchup periods with this call.
    /// However, the scoring period specified will contain the information that we need under the matchupPeriodId key.
    /// Filter the response to only include elements that contain the matchupPeriodId = scoringPeriodId 
    /// </summary>
    /// <param name="seasonId"></param>
    /// <param name="scoringPeriodId"></param>
    /// <returns></returns>
    public BoxScoreRoot[] GetBoxScoreForWeek(int seasonId, int scoringPeriodId)
    {
        var url = new Route(
            $"{seasonId}/segments/0/leagues/{leagueId}",
            $"?view=mMatchup&view=mMatchupScore&scoringPeriodId={scoringPeriodId}"
        ).ToString();
        
        var response = _httpProvider.GetResults<JsonElement>(url).GetProperty("schedule");
        
       return response.EnumerateArray()
                .Where(p => p.GetProperty("matchupPeriodId").ToString() == scoringPeriodId.ToString())
                .Select(element => element.Deserialize<BoxScoreRoot>())
                .ToArray();
       
    }

    public Task<DraftPlayer> GetDraftInfo(int seasonId, int scoringPeriodId = 0)
    {
        throw new NotImplementedException();
    }
    
}