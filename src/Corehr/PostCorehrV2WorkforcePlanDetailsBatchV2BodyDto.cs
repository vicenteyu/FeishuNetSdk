// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-28
//
// Last Modified By : yxr
// Last Modified On : 2025-02-28
// ************************************************************************
// <copyright file="PostCorehrV2WorkforcePlanDetailsBatchV2BodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询编制规划明细信息（支持自定义组织） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询编制规划明细信息（支持自定义组织） 请求体
/// <para>查询编制规划明细，包括维度信息、编制数、预估在职人数、在职人数和预增/预减人数。</para>
/// <para>接口ID：7473343327586435100</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/workforce_plan_detail/batch_v2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan_detail%2fbatch_v2</para>
/// </summary>
public record PostCorehrV2WorkforcePlanDetailsBatchV2BodyDto
{
    /// <summary>
    /// <para>编制规划方案ID，ID及详细信息可通过[获取编制规划方案列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/workforce_plan/list)接口查询获得。查询编制规划明细信息时，编制规划方案ID必填，是否为集中填报项目设置为false，不填写集中填报项目ID（是否填写不影响返回结果）</para>
    /// <para>必填：否</para>
    /// <para>示例值：781234834512</para>
    /// </summary>
    [JsonPropertyName("workforce_plan_id")]
    public string? WorkforcePlanId { get; set; }

    /// <summary>
    /// <para>是否为集中填报项目。如果租户未使用集中填报功能，将此参数置空即可。如果查询集中填报明细，将此参数设置为true。</para>
    /// <para>**字段权限要求**：获取编制规划集中填报明细信息(corehr:workforce_plan_centralized_reporting_project_detail:read)</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("is_centralized_reporting_project")]
    public bool? IsCentralizedReportingProject { get; set; }

    /// <summary>
    /// <para>编制规划集中填报项目ID，ID可通过访问集中填报页面，从URL中提取report_id参数。如果租户未使用集中填报功能，将此参数置空即可。查询集中填报信息时，集中填报项目ID必填，是否为集中填报项目设置为true，不填写编制规划方案ID（是否填写不影响返回结果）</para>
    /// <para>**字段权限要求**：获取编制规划集中填报明细信息(corehr:workforce_plan_centralized_reporting_project_detail:read)</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140964208476371111</para>
    /// </summary>
    [JsonPropertyName("centralized_reporting_project_id")]
    public string? CentralizedReportingProjectId { get; set; }

    /// <summary>
    /// <para>维度筛选</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("dimension_id_in_datas")]
    public DimensionIdInData[]? DimensionIdInDatas { get; set; }

    /// <summary>
    /// <para>维度筛选</para>
    /// </summary>
    public record DimensionIdInData
    {
        /// <summary>
        /// <para>维度key，可从下面列表中进行选择：</para>
        /// <para>- "department"：部门。</para>
        /// <para>- "employee_type" ：人员类型。</para>
        /// <para>- "location"：地点。</para>
        /// <para>- "position" ：岗位。</para>
        /// <para>- "cost_center" ：成本中心/业务线。</para>
        /// <para>- "job_family" ：序列。</para>
        /// <para>- "job_level" ：职级。</para>
        /// <para>- "job" ：职务。</para>
        /// <para>自定义组织：</para>
        /// <para>- "custom_org_01"</para>
        /// <para>- "custom_org_02"</para>
        /// <para>- "custom_org_03"</para>
        /// <para>- "custom_org_04"</para>
        /// <para>- "custom_org_05"</para>
        /// <para>必填：否</para>
        /// <para>示例值：department</para>
        /// </summary>
        [JsonPropertyName("dimension_key")]
        public string? DimensionKey { get; set; }

        /// <summary>
        /// <para>维度value。</para>
        /// <para>- department_id：可从[查询部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)获得。</para>
        /// <para>- location_id：可从[查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)获得。</para>
        /// <para>- cost_center_id：可从[查询成本中心](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)获得。</para>
        /// <para>- job_id：可从[查询职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)获得。</para>
        /// <para>- job_level_id：可从[查询职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)获得。</para>
        /// <para>- job_family_id：可从[查询序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)获得。</para>
        /// <para>- employee_type_id：可从[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)获得。</para>
        /// <para>- position_id：岗位，功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>- custom_org_01_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>- custom_org_02_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>- custom_org_03_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>- custom_org_04_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>- custom_org_05_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("dimension_ids")]
        public string[]? DimensionIds { get; set; }
    }
}
