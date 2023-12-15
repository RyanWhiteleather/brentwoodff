using EspnApi.Domain.Model;
using EspnApi.Domain.Provider;
using EspnApi.Domain.Service;

namespace EspnApi
{
    /**
     * Client to call the ESPN Fantasy Football API
     */
    public class EspnApiClient(int leagueId, string swid, string espnS2)
    {
        private readonly EspnApiService _espnApiService = new(new HttpProvider(swid, espnS2), new UrlConfigurationProvider(), leagueId);

        /// <summary>
        /// Returns ESPN fantasy football league data.
        /// </summary>
        /// <param name="seasonId">Year the season took place.</param>
        /// <returns></returns>
        public Task<League> GetLeagueBySeasonAsync(int seasonId)
        {
            return _espnApiService.GetLeagueAsync(seasonId);
        }
        
        /// <summary>
        /// Return the box scores for the week (matchup period)
        /// </summary>
        /// <param name="seasonId"></param>
        /// <param name="matchupPeriodId"></param>
        /// <param name="scoringPeriodId"></param>
        /// <returns></returns>
        public Task<BoxScore[]> GetBoxScoreForWeekAsync(int seasonId, int matchupPeriodId, int scoringPeriodId)
        {
            return _espnApiService.GetBoxScoreForWeek(seasonId, matchupPeriodId, scoringPeriodId);
        }

    }
}
