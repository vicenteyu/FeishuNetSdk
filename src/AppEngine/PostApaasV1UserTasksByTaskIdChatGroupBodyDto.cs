// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1UserTasksByTaskIdChatGroupBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>基于人工任务发起群聊 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 基于人工任务发起群聊 请求体
/// <para>基于任务，发起一个飞书群聊</para>
/// <para>接口ID：7446337145820413956</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/chat_group</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fchat_group</para>
/// </summary>
public record PostApaasV1UserTasksByTaskIdChatGroupBodyDto
{
    /// <summary>
    /// <para>操作人kunlunUserID,可通过Apaas用户管理页面获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234</para>
    /// </summary>
    [JsonPropertyName("operator_user_id")]
    public string OperatorUserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>邀请进群用户KunlunID列表,可通过Apaas用户管理页面获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("invite_user_ids")]
    public string[]? InviteUserIds { get; set; }

    /// <summary>
    /// <para>要拉入的群openID，为空则新建群</para>
    /// <para>必填：否</para>
    /// <para>示例值：oc_1234</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>要加入的群名称，当chat_id为空时用该名称创建群聊</para>
    /// <para>必填：否</para>
    /// <para>示例值：群名称</para>
    /// </summary>
    [JsonPropertyName("chat_name")]
    public string? ChatName { get; set; }
}
