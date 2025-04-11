// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="CorehrLocationCreatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建地点 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 创建地点 事件体
/// <para>飞书人事中「地点被创建」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=location&amp;event=created)</para>
/// <para>接口ID：7423693709786005507</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2fevents%2fcreated</para>
/// </summary>
public record CorehrLocationCreatedV2EventBodyDto() : EventBodyDto("corehr.location.created_v2")
{
    /// <summary>
    /// <para>地点ID。</para>
    /// <para>- 调用[【查询单个地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/get)、[【通过地点 ID 批量获取地点信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/location/batch_get)接口返回地点详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("location_id")]
    public string? LocationId { get; set; }
}
