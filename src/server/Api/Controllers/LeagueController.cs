using EspnApi;
using EspnApi.Domain.Model;
using EspnApi.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeagueController(IEspnApiService espnApiService) : ControllerBase
    {
        [HttpGet("{seasonId:int}")]
        public Task<League> GetLeagueBySeason(int seasonId)
        {
            return espnApiService.GetLeagueBySeasonAsync(seasonId);
        }

        [HttpGet("{seasonId:int}/{matchupPeriodId:int}/{scoringPeriodId:int}")]
        public BoxScoreRoot[] GetBoxScoreForWeek(int seasonId, int matchupPeriodId, int scoringPeriodId)
        {
            return espnApiService.GetBoxScoreForWeek(seasonId, matchupPeriodId, scoringPeriodId);
        }
    }
}
