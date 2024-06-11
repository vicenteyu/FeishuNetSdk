global using System.Text.Json.Serialization;
namespace FeishuNetSdk;

/// <summary>
/// 响应体
/// </summary>
public record FeishuResponse<T>
{
    /// <summary>
    /// 错误码，非 0 表示失败
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// 错误描述
    /// </summary>
    [JsonPropertyName("msg")]
    public string Msg { get; set; } = string.Empty;

    /// <summary>
    /// 业务数据
    /// </summary>
    [JsonPropertyName("data")]
    public T? Data { get; set; }

    /// <summary>
    /// 响应结果
    /// </summary>
    [JsonIgnore]
    public bool IsSuccess => Code == 0;

    /// <summary>
    /// 错误信息
    /// </summary>
    [JsonPropertyName("error")]
    public ErrorSuffix? Error { get; set; }

    /// <summary>
    /// 错误信息
    /// </summary>
    /// <param name="Message">错误消息</param>
    /// <param name="LogId">Log Id</param>
    /// <param name="FieldViolations">违规字段</param>
    public record ErrorSuffix([property: JsonPropertyName("message")] string? Message,
        [property: JsonPropertyName("log_id")] string? LogId,
        [property: JsonPropertyName("field_violations")] ErrorSuffix.FieldViolation[]? FieldViolations)
    {
        /// <summary>
        /// 违规字段
        /// </summary>
        /// <param name="Field">字段名</param>
        /// <param name="Value">字段值</param>
        /// <param name="Description">描述</param>
        public record FieldViolation([property: JsonPropertyName("field")] string Field,
            [property: JsonPropertyName("value")] string Value,
            [property: JsonPropertyName("description")] string Description);
    }
}

/// <summary>
/// 响应体
/// </summary>
public record FeishuResponse : FeishuResponse<object?> { }