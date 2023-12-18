using EspnApi;
using EspnApi.Domain.Model;
using EspnApi.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]/{seasonId:int}")]
    public class LeagueController(IEspnApiService espnApiService) : ControllerBase
    {
        [HttpGet]
        public Task<League> GetLeagueBySeason(int seasonId)
        {
            return espnApiService.GetLeagueBySeasonAsync(seasonId);
        }

        [HttpGet("{scoringPeriodId:int}")]
        public Task<BoxScoreRoot[]> GetBoxScoreForWeek(int seasonId, int scoringPeriodId)
        {
            return espnApiService.GetBoxScoreForWeekAsync(seasonId, scoringPeriodId);
        }
    }
}
