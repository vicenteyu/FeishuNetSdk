// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrJobCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建职务 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 创建职务 事件体
/// <para>飞书人事中「职务被创建」时将触发此事件。注意：触发时间为职务实际生效时间，如在 2022-01-01 创建职务，职务生效时间设置为 2022-05-01，事件将在 2022-05-01 进行推送。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=job&amp;event=created)</para>
/// <para>接口ID：7273083612789260291</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob%2fevents%2fcreated</para>
/// </summary>
public record CorehrJobCreatedV1EventBodyDto() : EventBodyDto("corehr.job.created_v1")
{
    /// <summary>
    /// <para>职务 ID，可通过[【查询单个职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)获取详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_id")]
    public string? JobId { get; set; }
}
