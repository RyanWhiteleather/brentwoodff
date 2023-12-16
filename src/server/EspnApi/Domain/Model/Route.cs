namespace EspnApi.Domain.Model;

/// <summary>
/// Creates the route to call the ESPN api.
/// </summary>
/// <param name="urlBase"></param>
/// <param name="urlParams"></param>
public class Route(string urlBase, string urlParams)
{
    public override string ToString()
    {
        return GetFantasyUrlBase() 
        +urlBase + urlParams;
    }
    
    /// <summary>
    /// Base URL for the V3 ESPN api
    /// </summary>
    /// <returns></returns>
    private static string GetFantasyUrlBase()
    {
        return "https://fantasy.espn.com/apis/v3/games/ffl/seasons/";
    }
}