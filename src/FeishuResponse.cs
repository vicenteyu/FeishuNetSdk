using Newtonsoft.Json;

namespace FeishuNetSdk;

public record FeishuResponse<T>
{
    /// <summary>
    /// 错误码，非 0 表示失败
    /// </summary>
    [JsonProperty("code")]
    public int Code { get; set; }

    /// <summary>
    /// 错误描述
    /// </summary>
    [JsonProperty("msg")]
    public string Msg { get; set; } = string.Empty;

    [JsonProperty("data")]
    public T? Data { get; set; }
}
