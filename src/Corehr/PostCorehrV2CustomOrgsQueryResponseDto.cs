// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询自定义组织信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询自定义组织信息 响应体
/// <para>根据传入的筛选条件批量查询自定义组织信息。不传任何筛选条件，默认获得该租户下所有的自定义组织数据。</para>
/// <para>接口ID：7358017162446520324</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fquery</para>
/// </summary>
public record PostCorehrV2CustomOrgsQueryResponseDto : IPageableResponse<PostCorehrV2CustomOrgsQueryResponseDto.CustomOrg>
{
    /// <summary>
    /// <para>自定义组织信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CustomOrg[]? Items { get; set; }

    /// <summary>
    /// <para>自定义组织信息列表</para>
    /// </summary>
    public record CustomOrg
    {
        /// <summary>
        /// <para>组织类型编码</para>
        /// <para>必填：是</para>
        /// <para>示例值：custom_org_01</para>
        /// </summary>
        [JsonPropertyName("object_api_name")]
        public string ObjectApiName { get; set; } = string.Empty;

        /// <summary>
        /// <para>组织名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：5</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("names")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>组织名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言，中文值是 zh-CN，英文值是 en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：中文示例</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：MDPD00000023</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>上级自定义组织 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>负责人 ID 列表</para>
        /// <para>- 返回的 ID 类型为 ==employment_id==</para>
        /// <para>- 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("manager_ids")]
        public string[]? ManagerIds { get; set; }

        /// <summary>
        /// <para>自定义组织描述</para>
        /// <para>必填：否</para>
        /// <para>最大长度：5</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>当前版本生效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
        /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string? EffectiveTime { get; set; }

        /// <summary>
        /// <para>组织角色列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("org_roles")]
        public OrgRole[]? OrgRoles { get; set; }

        /// <summary>
        /// <para>组织角色列表</para>
        /// </summary>
        public record OrgRole
        {
            /// <summary>
            /// <para>角色key</para>
            /// <para>- 可以通过页面「飞书人事-设置-组织配置」选择对应自定义组织，「字段配置-字段编码」获取</para>
            /// <para>必填：是</para>
            /// <para>示例值：hcm_corehr_xxx</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("api_name")]
            public string ApiName { get; set; } = string.Empty;

            /// <summary>
            /// <para>角色ID</para>
            /// <para>- 可以通过[批量获取角色列表](https://open.larkoffice.com/document/server-docs/corehr-v1/authorization/list) 获取，数据为返回数据中的 data.items.id 值。筛选条件data.items.group_type == 3（组织角色），data.items.org_truncation 关联的组织有且仅有一个，data.items.org_truncation.org_key 等于当前查询自定义组织 object_api_name</para>
            /// <para>必填：否</para>
            /// <para>示例值：7034393015968122400</para>
            /// </summary>
            [JsonPropertyName("security_group_id")]
            public string? SecurityGroupId { get; set; }

            /// <summary>
            /// <para>直接授权的员工 ID 列表</para>
            /// <para>- 返回的 ID 类型为 ==people_corehr_id==</para>
            /// <para>- 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("employment_ids")]
            public string[]? EmploymentIds { get; set; }

            /// <summary>
            /// <para>由于有上级组织权限而自动获取下级组织权限的员工 ID 列表</para>
            /// <para>- 返回的 ID 类型为 ==people_corehr_id==</para>
            /// <para>- 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("inherit_employment_ids")]
            public string[]? InheritEmploymentIds { get; set; }
        }

        /// <summary>
        /// <para>自动匹配的规则组。</para>
        /// <para>- 需要在「飞书人事-设置-组织设置」中打开对应组织类型的自动匹配开关后，此字段才会返回相关值。</para>
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
        /// <para>- 需要在「飞书人事-设置-组织设置」中打开对应组织类型的自动匹配开关后，此字段才会返回相关值。</para>
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
                /// <para>- ==department==和==department_hierarchy==：可通过[查询单个部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)获取详情，ID 类型需要为 ==people_corehr_department_id==。</para>
                /// <para>- ==work_location==和==work_location_hierarchy==：可通过[查询单个地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/get)获取详情。</para>
                /// <para>- ==cost_center==和==cost_center_hierarchy==：可通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)获取详情。</para>
                /// <para>- ==job==：可通过[查询单个职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)获取详情。</para>
                /// <para>- ==job_level==：可通过[查询单个职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)获取详情。</para>
                /// <para>- ==job_family==和==job_family_hierarchy==：可通过[查询单个序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)获取详情。</para>
                /// <para>- ==employee_type==：可通过[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)获取详情。</para>
                /// <para>必填：否</para>
                /// <para>最大长度：10000</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("right_values")]
                public string[]? RightValues { get; set; }
            }
        }

        /// <summary>
        /// <para>自定义组织是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>自定义组织 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
        /// </summary>
        public record CustomFieldData
        {
            /// <summary>
            /// <para>自定义字段 API Name，即自定义字段的唯一标识</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("custom_api_name")]
            public string CustomApiName { get; set; } = string.Empty;

            /// <summary>
            /// <para>自定义字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public CustomName? Name { get; set; }

            /// <summary>
            /// <para>自定义字段名称</para>
            /// </summary>
            public record CustomName
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：自定义姓名</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Custom Name</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同。如：```("123", "123.23", "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")```</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
