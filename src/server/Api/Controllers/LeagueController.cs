using EspnApi;
using EspnApi.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeagueController(ILogger<LeagueController> logger) : ControllerBase
    {
        private const int LEAGUE_ID = 324746;
        private const string SWID = "{C807AE6E-DA5E-4263-87AE-6EDA5E5263D3}";
        private const string ESPN_S2 = "AEBETYgH5ZK1fsO3xF9iH2GPiV7D%2BPzjcLrv%2F%2FJCBw2avLHhUEd04AA6xu9jn7M6IDr%2By8DwWkQjdpwiJEJlJPxyLl5UetHSUDlvIHp0hbJVU3SdCrNaSHW4Up1FS6m0NrBrE4glOh6hEmQMKAjU5ExhXBQ1n%2Bhz6RHqBfm0KzOBWsu032NgbjHf9D5%2FaulrJmHbqOOzErwN2hR4Uh47UoAG2aLT2A9lkOgvy9GLZoVYNzqmtU64eXbYqr0AbyjeJ7E1kISpJ4h7KWZCqnHDmnHQaIWKRndj35ns6zwKQLBQXeA5GFHSTlOnRcBKWFqxURMf%2FMoq80ETpil8yXyr58uo";
        
        private readonly ILogger<LeagueController> _logger = logger;

        private readonly EspnApiClient _espnApiClient = new(LEAGUE_ID, SWID, ESPN_S2);


        [HttpGet("{seasonId:int}")]
        public Task<League> GetLeagueBySeason(int seasonId)
        {
            return _espnApiClient.GetLeagueBySeasonAsync(seasonId);
        }
    }
}
