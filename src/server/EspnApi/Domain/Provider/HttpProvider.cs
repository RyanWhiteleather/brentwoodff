using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;

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
        return JsonConvert.DeserializeObject<T>(jsonResponse);
    }

    /// <summary>
    /// Returns just the string of the 
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public Task<string> GetStringAsync(string url)
    {
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        return _httpClient.GetStringAsync(url);
    }
        
}