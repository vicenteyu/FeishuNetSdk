using Newtonsoft.Json;

namespace FeishuNetSdk;

/// <summary>
/// 响应体
/// </summary>
public record FeishuResponse<T>
{
    /// <summary>
    /// 错误码，非 0 表示失败
    /// </summary>
    [JsonProperty("code")]
    public int? Code { get; set; }

    /// <summary>
    /// 错误描述
    /// </summary>
    [JsonProperty("msg")]
    public string Msg { get; set; } = string.Empty;

    /// <summary>
    /// 业务数据
    /// </summary>
    [JsonProperty("data")]
    public T? Data { get; set; }

    /// <summary>
    /// 响应结果
    /// </summary>
    public bool IsSuccess => Code == 0;
}

/// <summary>
/// 响应体
/// </summary>
public record FeishuResponse : FeishuResponse<object?> { }