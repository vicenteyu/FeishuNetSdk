// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrJobDataUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>任职信息更新 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 任职信息更新 事件体
/// <para>目前以下场景会触发该事件：</para>
/// <para>- 人事系统【编辑任职】【编辑兼职】【导入编辑任职】【发起异动】功能{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=job_data&amp;event=updated)</para>
/// <para>接口ID：7332312493681197060</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_data/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fevents%2fupdated</para>
/// </summary>
public record CorehrJobDataUpdatedV1EventBodyDto() : EventBodyDto("corehr.job_data.updated_v1")
{
    /// <summary>
    /// <para>ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_data_id")]
    public string? JobDataId { get; set; }
}
