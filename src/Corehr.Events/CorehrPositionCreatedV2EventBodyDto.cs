// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="CorehrPositionCreatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建岗位事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 创建岗位事件 事件体
/// <para>飞书人事中「岗位被创建」时将触发此事件。注意：触发时间为岗位实际生效时间，如在 2022-01-01 创建岗位，岗位生效时间设置为 2022-05-01，事件将在 2022-05-01 进行推送。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=position&amp;event=created)</para>
/// <para>接口ID：7389929945763987484</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fevents%2fcreated</para>
/// </summary>
public record CorehrPositionCreatedV2EventBodyDto() : EventBodyDto("corehr.position.created_v2")
{
    /// <summary>
    /// <para>岗位ID，可通过[查询岗位](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)接口去获取岗位详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("position_id")]
    public string? PositionId { get; set; }
}
