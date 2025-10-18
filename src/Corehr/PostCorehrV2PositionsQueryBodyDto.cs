// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCorehrV2PositionsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询岗位信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询岗位信息 请求体
/// <para>支持通过岗位 ID、部门 ID 查询岗位的详细信息，例如岗位关联的职务、职级、序列，以及岗位描述，是否关键岗位等</para>
/// <para>接口ID：7384280065851064321</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fquery</para>
/// </summary>
public record PostCorehrV2PositionsQueryBodyDto
{
    /// <summary>
    /// <para>部门 ID 列表</para>
    /// <para>- department_ids参数的ID类型需与department_id_type参数取值一致</para>
    /// <para>- 可通过飞书人事的[批量查询部门（ V2）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get) 来获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>生效日期，格式是 YYYY-MM-DD</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string? EffectiveTime { get; set; }

    /// <summary>
    /// <para>启停用状态：true 为启用，false 为停用，不传则默认都返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// <para>需要查询的字段列表，为空时仅返回 wk_id。可选以下预置字段及自定义字段：</para>
    /// <para>- "wk_id"：岗位 ID</para>
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
    /// <para>- "created_by"：创建人</para>
    /// <para>- "custom_fields"：自定义字段(需传入具体的"custom_api_name")详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query) ,比如:"shifouleixing_7795__c"</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }

    /// <summary>
    /// <para>岗位 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("position_ids")]
    public string[]? PositionIds { get; set; }

    /// <summary>
    /// <para>岗位 Code 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("position_codes")]
    public string[]? PositionCodes { get; set; }
}
