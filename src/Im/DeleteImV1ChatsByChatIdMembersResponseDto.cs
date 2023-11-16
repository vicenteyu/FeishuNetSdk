namespace FeishuNetSdk.Im;
/// <summary>
/// 将用户或机器人移出群聊 响应体
/// <para>将用户或机器人移出群聊。</para>
/// <para>接口ID：6946222929790468124</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fdelete</para>
/// </summary>
public record DeleteImV1ChatsByChatIdMembersResponseDto
{
    /// <summary>
    /// <para>无效成员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_id_list")]
    public string[]? InvalidIdList { get; set; }
}
