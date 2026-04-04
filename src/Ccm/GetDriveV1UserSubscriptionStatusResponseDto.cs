// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="GetDriveV1UserSubscriptionStatusResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询用户云文档事件订阅状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询用户云文档事件订阅状态 响应体
/// <para>该接口用于查询用户云文档事件的订阅状态。仅当is_subscribe（订阅状态）为 true，应用才可收到 “用户云文档事件”下的各类通知事件。</para>
/// <para>接口ID：7623827135371234255</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/user/subscription_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fuser%2fsubscription_status</para>
/// </summary>
public record GetDriveV1UserSubscriptionStatusResponseDto
{
    /// <summary>
    /// <para>订阅状态</para>
    /// <para>必填：是</para>
    /// <para>示例值："is_subscribe": true</para>
    /// </summary>
    [JsonPropertyName("is_subscribe")]
    public bool IsSubscribe { get; set; }
}
