namespace FeishuNetSdk.Services;

/// <summary>
/// 
/// </summary>
/// <param name="code"></param>
/// <param name="msg"></param>
/// <param name="logId"></param>
/// <param name="violations"></param>
public class FeishuBusinessException(int code, string msg, string? logId = null, FeishuResponse<object>.ErrorSuffix.FieldViolation[]? violations = null) : Exception($"飞书接口调用失败。Code: {code}, Msg: {msg}{(string.IsNullOrEmpty(logId) ? "" : $", LogId: {logId}")}")
{
    /// <summary>
    /// 
    /// </summary>
    public int Code { get; } = code;
    /// <summary>
    /// 
    /// </summary>
    public string? LogId { get; } = logId;
    /// <summary>
    /// 
    /// </summary>
    public FeishuResponse<object>.ErrorSuffix.FieldViolation[]? FieldViolations { get; } = violations;
}