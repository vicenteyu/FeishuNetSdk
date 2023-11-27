namespace FeishuNetSdk.Search;
/// <summary>
/// 搜索消息 请求体
/// <para>用户可以通过关键字搜索可见消息，可见性和套件内搜索一致。</para>
/// <para>接口ID：7208771563588059139</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/suite-search/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fmessage%2fcreate</para>
/// </summary>
public record PostSearchV2MessageBodyDto
{
    /// <summary>
    /// <para>搜索关键词</para>
    /// <para>必填：是</para>
    /// <para>示例值：测试消息</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息来自user_id列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_1970b39a6730a4a8e97b530d8cb14ccb</para>
    /// </summary>
    [JsonPropertyName("from_ids")]
    public string[]? FromIds { get; set; }

    /// <summary>
    /// <para>消息所在chat_id列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：oc_c063434856a818a615fd36697a9ffe09</para>
    /// </summary>
    [JsonPropertyName("chat_ids")]
    public string[]? ChatIds { get; set; }

    /// <summary>
    /// <para>消息类型(file/image/media)</para>
    /// <para>必填：否</para>
    /// <para>示例值：image</para>
    /// <para>可选值：<list type="bullet">
    /// <item>file：文件</item>
    /// <item>image：图片</item>
    /// <item>media：视频</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("message_type")]
    public string? MessageType { get; set; }

    /// <summary>
    /// <para>at用户user_id列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_1970b39a6730a4a8e97b530d8cb14ccb</para>
    /// </summary>
    [JsonPropertyName("at_chatter_ids")]
    public string[]? AtChatterIds { get; set; }

    /// <summary>
    /// <para>消息来自类型(bot/user)</para>
    /// <para>必填：否</para>
    /// <para>示例值：user</para>
    /// <para>可选值：<list type="bullet">
    /// <item>bot：机器人</item>
    /// <item>user：用户</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("from_type")]
    public string? FromType { get; set; }

    /// <summary>
    /// <para>会话类型(group_chat/p2p_chat)</para>
    /// <para>必填：否</para>
    /// <para>示例值：group_chat</para>
    /// <para>可选值：<list type="bullet">
    /// <item>group_chat：群聊</item>
    /// <item>p2p_chat：单聊</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("chat_type")]
    public string? ChatType { get; set; }

    /// <summary>
    /// <para>消息发送起始时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1609296809</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// <para>消息发送结束时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1609296809</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }
}
