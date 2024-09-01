// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrJobDataChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>员工完成异动 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 员工完成异动 事件体
/// <para>员工在飞书人事异动生效后（到达异动生效时间）将触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=job_data&amp;event=changed)</para>
/// <para>接口ID：7085168201680814083</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fevents%2fchanged</para>
/// </summary>
public record CorehrJobDataChangedV1EventBodyDto() : EventBodyDto("corehr.job_data.changed_v1")
{
    /// <summary>
    /// <para>任职信息 ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_data_id")]
    public string? JobDataId { get; set; }

    /// <summary>
    /// <para>雇佣信息 ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>用户 ID，飞书相关ID</para>
    /// <para>可通过[【通讯录接口】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_user_id")]
    public UserIdSuffix? TargetUserId { get; set; }

    /// <summary>
    /// <para>员工异动 ID，可通过[【搜索异动信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_change_id")]
    public string? JobChangeId { get; set; }
}
