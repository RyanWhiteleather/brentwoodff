using System.Text.Json;

namespace EspnApi.Domain.Extensions;

/// <summary>
/// Extension method to setup the default JsonSerializerOptions.
/// </summary>
public static class DeserializeExtensions
{
    private static readonly JsonSerializerOptions DefaultSerializerSettings = new()
    {
        PropertyNameCaseInsensitive = true
    };
    
    public static T Deserialize<T>(this JsonElement json)
    {		
        return json.Deserialize<T>(DefaultSerializerSettings);
    }
}