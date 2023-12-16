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
    }
}
