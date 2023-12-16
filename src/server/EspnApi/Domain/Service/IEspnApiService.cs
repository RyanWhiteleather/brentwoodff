using EspnApi.Domain.Model;

namespace EspnApi.Domain.Service;

public interface IEspnApiService
{
    Task<League> GetLeagueBySeasonAsync(int seasonId);

    Task<BoxScore[]> GetBoxScoreForWeekAsync(int seasonId, int matchupPeriodId, int scoringPeriodId);

    Task<DraftPlayer> GetDraftInfo(int seasonId, int scoringPeriodId = 0);
}