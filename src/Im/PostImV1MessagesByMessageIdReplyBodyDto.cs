namespace FeishuNetSdk.Im;
/// <summary>
/// 回复消息 请求体
/// <para>回复指定消息，支持文本、富文本、卡片、群名片、个人名片、图片、视频、文件等多种消息类型。</para>
/// <para>接口ID：6946222929790500892</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/reply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2freply</para>
/// </summary>
public record PostImV1MessagesByMessageIdReplyBodyDto
{
    /// <summary>
    /// <para>消息内容 json 格式，格式说明参考: [发送消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)</para>
    /// <para>必填：是</para>
    /// <para>示例值：`{\"text\":\"test content\"}`</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息类型，包括：text、post、image、file、audio、media、sticker、interactive、share_card、share_user</para>
    /// <para>必填：是</para>
    /// <para>示例值：text</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>由开发者生成的唯一字符串序列，用于回复消息请求去重；持有相同uuid的请求1小时内至多成功执行一次</para>
    /// <para>必填：否</para>
    /// <para>示例值：选填，若填写每次调用前请更换，如：a0d69e20-1dd1-458b-k525-dfeca4015204</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}
