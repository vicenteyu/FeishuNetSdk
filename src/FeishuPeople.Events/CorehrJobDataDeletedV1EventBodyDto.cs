// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrJobDataDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>任职信息删除 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 任职信息删除 事件体
/// <para>目前以下场景会触发事件：</para>
/// <para>- 调用[【删除任职信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_data/delete)接口</para>
/// <para>- 人事系统【删除任职】【删除兼职】功能{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=job_data&amp;event=deleted)</para>
/// <para>接口ID：7332312493681180676</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/job-data-events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fevents%2fdeleted</para>
/// </summary>
public record CorehrJobDataDeletedV1EventBodyDto() : EventBodyDto("corehr.job_data.deleted_v1")
{
    /// <summary>
    /// <para>ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_data_id")]
    public string? JobDataId { get; set; }
}
