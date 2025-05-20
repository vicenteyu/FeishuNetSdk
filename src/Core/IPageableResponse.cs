namespace FeishuNetSdk.Core;

/// <summary>
/// 分页响应体接口
/// </summary>
public interface IPageableResponse<out TRecord>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    bool? HasMore { get; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    string? PageToken { get; }

    /// <summary>
    /// 分页数据项
    /// </summary>
    TRecord[]? Items { get; }
}
