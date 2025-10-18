// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="CorehrPositionUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新岗位事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 更新岗位事件 事件体
/// <para>飞书人事中「岗位信息被更新」时将触发此事件。注意：触发时间为岗位更新实际生效时间，如在 2022-01-01 更新岗位，岗位更新生效时间设置为 2022-05-01，事件将在 2022-05-01 进行推送。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=position&amp;event=updated)</para>
/// <para>接口ID：7389929945764003868</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fevents%2fupdated</para>
/// </summary>
public record CorehrPositionUpdatedV2EventBodyDto() : EventBodyDto("corehr.position.updated_v2")
{
    /// <summary>
    /// <para>岗位ID，可通过[查询岗位](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)接口去获取岗位详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("position_id")]
    public string? PositionId { get; set; }

    /// <summary>
    /// <para>发生变更的字段，包括以下预置字段及自定义字段：</para>
    /// <para>- "name"：名称</para>
    /// <para>- "code"：编码</para>
    /// <para>- "active"：状态</para>
    /// <para>- "department"：所属部门</para>
    /// <para>- "cost_center"：岗位默认成本中心</para>
    /// <para>- "job"：职务</para>
    /// <para>- "job_family"：序列</para>
    /// <para>- "job_level"：职级</para>
    /// <para>- "job_grade"：职等</para>
    /// <para>- "work_location"：工作地点</para>
    /// <para>- "employee_type"：人员类型</para>
    /// <para>- "working_hours_type"：工时制度</para>
    /// <para>- "direct_leader"：直属上级</para>
    /// <para>- "dotted_line_leader"：虚线上级</para>
    /// <para>- "is_key_position"：是否关键岗位</para>
    /// <para>- "description"：描述</para>
    /// <para>- "effective_time"：版本生效日期</para>
    /// <para>- "expiration_time"：版本过期时间</para>
    /// <para>自定义字段详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `200`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_changes")]
    public string[]? FieldChanges { get; set; }
}
