// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-18
//
// Last Modified By : yxr
// Last Modified On : 2024-09-18
// ************************************************************************
// <copyright file="CorehrJobLevelCreatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建职级 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 创建职级 事件体
/// <para>飞书人事中「职级被创建」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=job_level&amp;event=created)</para>
/// <para>接口ID：7414100499044630556</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_level%2fevents%2fcreated</para>
/// </summary>
public record CorehrJobLevelCreatedV2EventBodyDto() : EventBodyDto("corehr.job_level.created_v2")
{
    /// <summary>
    /// <para>职级ID。</para>
    /// <para>- 调用[【查询单个职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)、[【通过职级 ID 批量获取职级信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)接口返回职级详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_level_id")]
    public string? JobLevelId { get; set; }
}
