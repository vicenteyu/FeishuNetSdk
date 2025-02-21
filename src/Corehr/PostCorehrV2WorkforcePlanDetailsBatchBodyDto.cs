// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-18
//
// Last Modified By : yxr
// Last Modified On : 2024-09-18
// ************************************************************************
// <copyright file="PostCorehrV2WorkforcePlanDetailsBatchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询编制规划明细信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询编制规划明细信息（不支持自定义组织） 请求体
/// <para>查询编制规划明细，包括维度信息、编制数和预估在职人数</para>
/// <para>接口ID：7314710843818524673</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/workforce_plan_detail/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan_detail%2fbatch</para>
/// </summary>
public record PostCorehrV2WorkforcePlanDetailsBatchBodyDto
{
    /// <summary>
    /// <para>编制规划方案 ID， ID及详细信息可通过[获取编制规划方案列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/workforce_plan/list)接口查询获得。查询编制规划明细信息时，编制规划方案 ID 必填。</para>
    /// <para>必填：否</para>
    /// <para>示例值：781234834512</para>
    /// </summary>
    [JsonPropertyName("workforce_plan_id")]
    public string? WorkforcePlanId { get; set; }

    /// <summary>
    /// <para>是否为集中填报项目。如果租户未使用集中填报功能，将此参数置空即可。</para>
    /// <para>**字段权限要求**：获取编制规划集中填报明细信息(corehr:workforce_plan_centralized_reporting_project_detail:read)</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("is_centralized_reporting_project")]
    public bool? IsCentralizedReportingProject { get; set; }

    /// <summary>
    /// <para>编制规划集中填报项目 ID。ID可根据集中填报链接获取。如果租户未使用集中填报功能，将此参数置空即可。查询集中填报信息时，将以集中填报ID为准，无需填写编制规划方案 ID。</para>
    /// <para>**字段权限要求**：获取编制规划集中填报明细信息(corehr:workforce_plan_centralized_reporting_project_detail:read)</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140964208476371111</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("centralized_reporting_project_id")]
    public string? CentralizedReportingProjectId { get; set; }

    /// <summary>
    /// <para>部门ID列表。ID获取方式：</para>
    /// <para>- 调用[【创建部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/create)[【搜索部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search)等接口可以返回部门ID</para>
    /// <para>- 也可以通过[【事件】创建部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created)[【事件】更新部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/updated) 获取部门ID信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>人员类型 ID 列表</para>
    /// <para>- 可通过[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)获取详情。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("employee_type_ids")]
    public string[]? EmployeeTypeIds { get; set; }

    /// <summary>
    /// <para>工作地点 ID 列表。ID获取方式：</para>
    /// <para>- 调用[【创建地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/create)[【批量分页查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)等接口可以返回地点ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("work_location_ids")]
    public string[]? WorkLocationIds { get; set; }

    /// <summary>
    /// <para>序列 ID 列表。ID获取方式：</para>
    /// <para>- 调用[【新建序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/create)[【查询租户的序列信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)等接口可以返回序列ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_family_ids")]
    public string[]? JobFamilyIds { get; set; }

    /// <summary>
    /// <para>职级ID。ID获取方式：</para>
    /// <para>- 调用[【新建职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/create)[【查询租户的职级信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)等接口可以返回职级ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_level_ids")]
    public string[]? JobLevelIds { get; set; }

    /// <summary>
    /// <para>职务ID。ID获取方式：</para>
    /// <para>- 调用[【创建职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/create)[【批量查询职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)等可以返回职务ID</para>
    /// <para>- 也可以通过[【事件】创建职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/events/created) [【事件】更新职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/events/updated) 获取ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_ids")]
    public string[]? JobIds { get; set; }

    /// <summary>
    /// <para>成本中心 ID 列表。ID获取方式：</para>
    /// <para>- 调用[【创建成本中心】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/create)[【搜索成本中心】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)等接口可以返回成本中心ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("cost_center_ids")]
    public string[]? CostCenterIds { get; set; }
}
