using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;


namespace EspnApi.Domain.Provider;

public class HttpProvider
{
    private readonly HttpClient _httpClient;
        
        
    /// <summary>
    /// Creates the HttpProvider to handle the HTTP requests.  
    /// </summary>
    /// <param name="swid"></param>
    /// <param name="espnS2"></param>
    public HttpProvider(string swid, string espnS2)
    {
        Uri target = new("https://fantasy.espn.com");
        CookieContainer cookies = new();
        cookies.Add(new Cookie { Name = "SWID", Value = swid, Domain = target.Host});
        cookies.Add(new Cookie { Name = "espn_s2", Value = espnS2, Domain = target.Host });
        var handler = new HttpClientHandler();
        handler.CookieContainer = cookies;

        _httpClient = new HttpClient(handler, false);
    }


    public async Task<T> GetAsync<T>(string url)
    {
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var jsonResponse = await _httpClient.GetStringAsync(url);
        return JsonSerializer.Deserialize<T>(jsonResponse);
    }
}