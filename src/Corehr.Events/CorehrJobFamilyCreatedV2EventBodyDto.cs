// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-18
//
// Last Modified By : yxr
// Last Modified On : 2024-09-18
// ************************************************************************
// <copyright file="CorehrJobFamilyCreatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建序列 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 创建序列 事件体
/// <para>飞书人事中「序列被创建」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=job_family&amp;event=created)</para>
/// <para>接口ID：7414100499044696092</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_family%2fevents%2fcreated</para>
/// </summary>
public record CorehrJobFamilyCreatedV2EventBodyDto() : EventBodyDto("corehr.job_family.created_v2")
{
    /// <summary>
    /// <para>序列ID。</para>
    /// <para>- 调用[【查询单个序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)、[【通过序列 ID 批量查询序列信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)接口返回序列详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_family_id")]
    public string? JobFamilyId { get; set; }
}
