// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="PostMinutesV1MinutesUnsubscriptionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>取消订阅妙记变更事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Minutes;
/// <summary>
/// 取消订阅妙记变更事件 请求体
/// <para>取消订阅当前用户身份相关的妙记资源变更事件。通过指定事件类型，来取消订阅妙记资源对应的事件变更。</para>
/// <para>接口ID：7644841241634032587</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/unsubscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2funsubscription</para>
/// </summary>
public record PostMinutesV1MinutesUnsubscriptionBodyDto
{
    /// <summary>
    /// <para>事件类型</para>
    /// <para>**可选值有:**</para>
    /// <para>- `minutes.minute.generated_v1`: 妙记生成事件</para>
    /// <para>必填：否</para>
    /// <para>示例值：minutes.minute.generated_v1</para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public string? EventType { get; set; }
}
