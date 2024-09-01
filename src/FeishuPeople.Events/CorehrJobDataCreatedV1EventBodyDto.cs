// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrJobDataCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>任职信息创建 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 任职信息创建 事件体
/// <para>目前以下场景会触发该事件：</para>
/// <para>- 调用[【创建任职信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_data/create)、[【更新任职信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_data/patch)、[【添加人员】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/create)接口</para>
/// <para>- 人事系统【添加人员】、【发起异动】、【导入任职】、【创建兼职】功能{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=job_data&amp;event=created)</para>
/// <para>接口ID：7332312493681164292</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_data/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fevents%2fcreated</para>
/// </summary>
public record CorehrJobDataCreatedV1EventBodyDto() : EventBodyDto("corehr.job_data.created_v1")
{
    /// <summary>
    /// <para>ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_data_id")]
    public string? JobDataId { get; set; }
}
