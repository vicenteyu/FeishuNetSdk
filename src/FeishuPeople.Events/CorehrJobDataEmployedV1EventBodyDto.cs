// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrJobDataEmployedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>员工完成入职 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 员工完成入职 事件体
/// <para>两种场景触发此事件：</para>
/// <para>- 开放平台[操作员工完成入职](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/complete)接口</para>
/// <para>- 「飞书人事-人员管理-入职」将待入职员工操作“完成入职”{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=job_data&amp;event=employed)</para>
/// <para>接口ID：7084239806838013955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/employed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fevents%2femployed</para>
/// </summary>
public record CorehrJobDataEmployedV1EventBodyDto() : EventBodyDto("corehr.job_data.employed_v1")
{
    /// <summary>
    /// <para>任职记录 ID，详细信息可通过[【获取任职记录】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_data/get)接口查询</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_data_id")]
    public string? JobDataId { get; set; }

    /// <summary>
    /// <para>雇佣记录 ID，详细信息可通过[【查询员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口查询</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>用户 ID（备注：入职后开通飞书账号成功，会生成飞书通讯录相关ID，但由于开通过程是异步，本事件不保证一定返回，如未返回，说明飞书账号开通失败，业务需兼容处理）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_user_id")]
    public UserIdSuffix? TargetUserId { get; set; }
}
