// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="CorehrJobGradeCreatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建职等 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 创建职等 事件体
/// <para>飞书人事中「职等被创建」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=job_grade&amp;event=created)</para>
/// <para>接口ID：7423693709786054659</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_grade/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fevents%2fcreated</para>
/// </summary>
public record CorehrJobGradeCreatedV2EventBodyDto() : EventBodyDto("corehr.job_grade.created_v2")
{
    /// <summary>
    /// <para>职等ID。</para>
    /// <para>- 调用[【批量查询职等信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)接口返回职等详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_grade_id")]
    public string? JobGradeId { get; set; }
}
