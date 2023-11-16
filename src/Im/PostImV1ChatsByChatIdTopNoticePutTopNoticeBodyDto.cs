namespace FeishuNetSdk.Im;
/// <summary>
/// 更新群置顶 请求体
/// <para>更新会话中的群置顶信息，可以将群中的某一条消息，或者群公告置顶显示。</para>
/// <para>接口ID：7043611687799816193</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/put_top_notice</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-top_notice%2fput_top_notice</para>
/// </summary>
public record PostImV1ChatsByChatIdTopNoticePutTopNoticeBodyDto
{
    /// <summary>
    /// <para>要进行发布的群置顶</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("chat_top_notice")]
    public ChatTopNotice[] ChatTopNotices { get; set; } = Array.Empty<ChatTopNotice>();

    /// <summary>
    /// <para>要进行发布的群置顶</para>
    /// </summary>
    public record ChatTopNotice
    {
        /// <summary>
        /// <para>置顶的类型</para>
        /// <para>**注意**：</para>
        /// <para>- 选择 ==消息类型== 时必须填写`message_id`字段</para>
        /// <para>- 选择 ==群公告类型== 时填写的`message_id`将被忽略</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：消息类型</item>
        /// <item>2：群公告类型</item>
        /// </list></para>
        /// <para>默认值：2</para>
        /// </summary>
        [JsonPropertyName("action_type")]
        public string? ActionType { get; set; }

        /// <summary>
        /// <para>消息ID，详情参见[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }
    }
}
