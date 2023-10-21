using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 判断用户或机器人是否在群里 响应体
/// <para>根据使用的access_token判断对应的用户或者机器人是否在群里。</para>
/// <para>接口ID：6946222929790418972</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/is_in_chat</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fis_in_chat</para>
/// </summary>
public record GetImV1ChatsByChatIdMembersIsInChatResponseDto
{
    /// <summary>
    /// <para>用户或者机器人是否在群中</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("is_in_chat")]
    public bool? IsInChat { get; set; }
}
