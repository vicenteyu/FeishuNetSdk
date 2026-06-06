// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PostVcV1NotesSubscriptionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>订阅纪要变更事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 订阅纪要变更事件 请求体
/// <para>订阅当前用户身份相关的纪要资源变更事件。通过指定事件类型，来订阅纪要资源不同的事件变更。</para>
/// <para>接口ID：7646314141168291027</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/note/subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fnote%2fsubscription</para>
/// </summary>
public record PostVcV1NotesSubscriptionBodyDto
{
    /// <summary>
    /// <para>事件类型</para>
    /// <para>**可选值有:**</para>
    /// <para>- `vc.note.generated_v1`: 纪要生成事件</para>
    /// <para>必填：否</para>
    /// <para>示例值：vc.note.generated_v1</para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public string? EventType { get; set; }
}
