// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1UserTasksByTaskIdChatGroupResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>基于人工任务发起群聊 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 基于人工任务发起群聊 响应体
/// <para>基于任务，发起一个飞书群聊</para>
/// <para>接口ID：7446337145820413956</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/user_task/chat_group</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fchat_group</para>
/// </summary>
public record PostApaasV1UserTasksByTaskIdChatGroupResponseDto
{
    /// <summary>
    /// <para>创建的群聊ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }
}
