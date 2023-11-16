namespace FeishuNetSdk.Im;
/// <summary>
/// 发送消息 请求体
/// <para>给指定用户或者会话发送消息，支持文本、富文本、可交互的[消息卡片](https://open.feishu.cn/document/ukTMukTMukTM/uczM3QjL3MzN04yNzcDN)、群名片、个人名片、图片、视频、音频、文件、表情包。</para>
/// <para>接口ID：6946222931479527425</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fcreate</para>
/// </summary>
public record PostImV1MessagesBodyDto
{
    /// <summary>
    /// <para>消息接收者的ID，ID类型应与查询参数==receive_id_type== 对应；推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("receive_id")]
    public string ReceiveId { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息类型 包括：text、post、image、file、audio、media、sticker、interactive、share_chat、share_user等，类型定义请参考[发送消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)</para>
    /// <para>必填：是</para>
    /// <para>示例值：text</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息内容，JSON结构序列化后的字符串。不同msg_type对应不同内容，具体格式说明参考：[发送消息Content](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)</para>
    /// <para>**注意：**</para>
    /// <para>- JSON字符串需进行转义，如换行符转义后为`\\n`</para>
    /// <para>- 文本消息请求体最大不能超过150KB</para>
    /// <para>- 卡片及富文本消息请求体最大不能超过30KB</para>
    /// <para>必填：是</para>
    /// <para>示例值：`{\"text\":\"test content\"}`</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>由开发者生成的唯一字符串序列，用于发送消息请求去重；持有相同uuid的请求1小时内至多成功发送一条消息</para>
    /// <para>必填：否</para>
    /// <para>示例值：选填，若填写每次调用前请更换，如：a0d69e20-1dd1-458b-k525-dfeca4015204</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}
