// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgsUpdateRuleBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新自定义组织的匹配规则 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新自定义组织的匹配规则 请求体
/// <para>更新自定义组织的匹配规则。仅开启了「为组织设置自动匹配规则」的自定义组织类型可用。如需更新自定义组织基本信息可使用[更新自定义组织](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/custom_org/patch)</para>
/// <para>接口ID：7358017162446553092</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/update_rule</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fupdate_rule</para>
/// </summary>
public record PostCorehrV2CustomOrgsUpdateRuleBodyDto
{
    /// <summary>
    /// <para>组织类型编码，可在「飞书人事-设置-组织设置」中相应的自定义组织目录下查看</para>
    /// <para>必填：是</para>
    /// <para>示例值：custom_org_01</para>
    /// </summary>
    [JsonPropertyName("object_api_name")]
    public string ObjectApiName { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义组织 ID</para>
    /// <para>- 可从 [批量查询自定义组织](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/custom_org/query)的 org_id 字段中获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("org_id")]
    public string OrgId { get; set; } = string.Empty;

    /// <summary>
    /// <para>自动匹配的规则组。</para>
    /// <para>- 需要在「飞书人事-设置-组织设置」中打开对应组织类型的自动匹配开关后，才可以使用匹配规则组字段。</para>
    /// <para>- 各个==match_rule_groups==之间是并集关系</para>
    /// <para>- 各个==match_rules==之间是交集关系</para>
    /// <para>必填：否</para>
    /// <para>最大长度：16</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("match_rule_groups")]
    public MatchRules[]? MatchRuleGroups { get; set; }

    /// <summary>
    /// <para>自动匹配的规则组。</para>
    /// <para>- 需要在「飞书人事-设置-组织设置」中打开对应组织类型的自动匹配开关后，才可以使用匹配规则组字段。</para>
    /// <para>- 各个==match_rule_groups==之间是并集关系</para>
    /// <para>- 各个==match_rules==之间是交集关系</para>
    /// </summary>
    public record MatchRules
    {
        /// <summary>
        /// <para>匹配规则列表，组内是交集关系</para>
        /// <para>必填：否</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("match_rules")]
        public MatchRule[]? MatchRulesSuffixs { get; set; }

        /// <summary>
        /// <para>匹配规则列表，组内是交集关系</para>
        /// </summary>
        public record MatchRule
        {
            /// <summary>
            /// <para>左值</para>
            /// <para>必填：是</para>
            /// <para>示例值：department</para>
            /// <para>可选值：<list type="bullet">
            /// <item>department：部门</item>
            /// <item>department_hierarchy：部门（含下级）</item>
            /// <item>work_location：工作地点</item>
            /// <item>work_location_hierarchy：工作地点（含下级）</item>
            /// <item>cost_center：成本中心</item>
            /// <item>cost_center_hierarchy：成本中心（含下级）</item>
            /// <item>job：职务</item>
            /// <item>job_level：职级</item>
            /// <item>job_family：序列</item>
            /// <item>job_family_hierarchy：序列（含下级）</item>
            /// <item>employee_type：人员类型</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("left_value")]
            public string LeftValue { get; set; } = string.Empty;

            /// <summary>
            /// <para>操作符</para>
            /// <para>必填：是</para>
            /// <para>示例值：contains</para>
            /// <para>可选值：<list type="bullet">
            /// <item>contains：包含</item>
            /// <item>notContains：不包含</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("operator")]
            public string Operator { get; set; } = string.Empty;

            /// <summary>
            /// <para>右值，填写左值对应的 ID 列表。</para>
            /// <para>- ==department==和==department_hierarchy==：详细 ID 可通过[查询单个部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)接口获得，ID 类型需要为 ==people_corehr_department_id==。</para>
            /// <para>- ==work_location==和==work_location_hierarchy==：详细 ID 可通过[查询单个地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/get)接口获得。</para>
            /// <para>- ==cost_center==和==cost_center_hierarchy==：详细 ID 可通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获得。</para>
            /// <para>- ==job==：详细 ID 可通过[查询单个职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)接口获得。</para>
            /// <para>- ==job_level==：详细 ID 可通过[查询单个职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)接口获得。</para>
            /// <para>- ==job_family==和==job_family_hierarchy==：详细 ID 可通过[查询单个序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)接口获得。</para>
            /// <para>- ==employee_type==：详细 ID 可通过[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)接口获得。</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("right_values")]
            public string[]? RightValues { get; set; }
        }
    }
}
