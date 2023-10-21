using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 指定群管理员 响应体
/// <para>将用户或机器人指定为群管理员。</para>
/// <para>接口ID：6995085510524698625</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/add_managers</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-managers%2fadd_managers</para>
/// </summary>
public record PostImV1ChatsByChatIdManagersAddManagersResponseDto
{
    /// <summary>
    /// <para>群目前用户类型的管理员 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("chat_managers")]
    public string[]? ChatManagers { get; set; }

    /// <summary>
    /// <para>群目前机器人类型的管理员 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("chat_bot_managers")]
    public string[]? ChatBotManagers { get; set; }
}
