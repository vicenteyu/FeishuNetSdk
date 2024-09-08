global using FeishuNetSdk.Converters;
using System.Text.Json;

namespace FeishuNetSdk.Converters
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    public class SnakeCaseLowerConverter<TEnum>()
        : JsonStringEnumConverter<TEnum>(namingPolicy: JsonNamingPolicy.SnakeCaseLower) where TEnum : struct, Enum
    { }

}
