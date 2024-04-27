namespace FeishuNetSdk.Aily;
/// <summary>
/// 创建会话 请求体
/// <para>该 API 用于创建与某个飞书智能伙伴应用的一次会话（Session）；当创建会话成功后，可以发送消息、创建运行</para>
/// <para>接口ID：7358047310868316164</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session%2fcreate</para>
/// </summary>
public record PostAilyV1SessionsBodyDto
{
    /// <summary>
    /// <para>渠道上下文</para>
    /// <para>必填：否</para>
    /// <para>示例值：{}</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("channel_context")]
    public string? ChannelContext { get; set; }

    /// <summary>
    /// <para>其他透传信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：{}</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}
