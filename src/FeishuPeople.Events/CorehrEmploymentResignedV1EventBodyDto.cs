// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrEmploymentResignedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>员工完成离职 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 员工完成离职 事件体
/// <para>员工完成离职，即离职日期的次日凌晨时，员工雇佣状态更改为“离职”后触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=employment&amp;event=resigned)</para>
/// <para>接口ID：7084239806834851843</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/resigned</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fevents%2fresigned</para>
/// </summary>
public record CorehrEmploymentResignedV1EventBodyDto() : EventBodyDto("corehr.employment.resigned_v1")
{
    /// <summary>
    /// <para>离职员工雇佣ID，可通过[批量查询员工信息</para>
    /// <para>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取员工信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }
}
