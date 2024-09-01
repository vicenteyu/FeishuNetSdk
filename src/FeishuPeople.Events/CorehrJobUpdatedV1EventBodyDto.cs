// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrJobUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新职务 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 更新职务 事件体
/// <para>飞书人事中「职务信息被更新」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=job&amp;event=updated)</para>
/// <para>接口ID：7273083612789227523</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob%2fevents%2fupdated</para>
/// </summary>
public record CorehrJobUpdatedV1EventBodyDto() : EventBodyDto("corehr.job.updated_v1")
{
    /// <summary>
    /// <para>Job ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_id")]
    public string? JobId { get; set; }
}
