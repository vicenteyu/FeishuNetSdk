using System.Text.Json;

namespace FeishuNetSdk.Tests;

public class TestBase
{
    protected static T? Deserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json, Programs.JsonSerializerOptions);
    }
}
