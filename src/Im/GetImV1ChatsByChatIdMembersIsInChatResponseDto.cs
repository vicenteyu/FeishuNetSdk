// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1ChatsByChatIdMembersIsInChatResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>判断用户或机器人是否在群里 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 判断用户或机器人是否在群里 响应体
/// <para>根据使用的 access_token 判断对应的用户或者机器人是否在指定的群里。</para>
/// <para>## 前提条件</para>
/// <para>调用该接口的应用，需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>获取内部群信息时，操作者须与群组在同一租户下。</para>
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
    [JsonPropertyName("is_in_chat")]
    public bool? IsInChat { get; set; }
}
