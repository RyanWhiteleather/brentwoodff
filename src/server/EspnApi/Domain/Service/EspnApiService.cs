using EspnApi.Domain.Model;
using EspnApi.Domain.Provider;

namespace EspnApi.Domain.Service;

public class EspnApiService(
    HttpProvider httpProvider,
    UrlConfigurationProvider urlConfigurationProvider,
    int leagueId)
{
    public Task<League> GetLeagueAsync(int seasonId)
    {
        string url = UrlConfigurationProvider.GetLeagueEndpointUrl(leagueId, seasonId);
        return httpProvider.GetAsync<League>(url);
    }

    public Task<BoxScore[]> GetBoxScoreForWeek(int seasonId, int matchupPeriodId, int scoringPeriodId)
    {
        throw new NotImplementedException();
    }
}