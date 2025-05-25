// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PatchCorehrV2CustomOrgsByOrgIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新自定义组织信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新自定义组织信息 请求体
/// <para>更新一个自定义组织基础信息，不支持更新自动匹配规则，如需更新自动匹配规则请使用[更新匹配规则](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/custom_org/update_rule)</para>
/// <para>接口ID：7358017162446536708</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fpatch</para>
/// </summary>
public record PatchCorehrV2CustomOrgsByOrgIdBodyDto
{
    /// <summary>
    /// <para>组织类型编码，可在「飞书人事-设置-组织设置」中相应的自定义组织目录下查看</para>
    /// <para>必填：是</para>
    /// <para>示例值：custom_org_01</para>
    /// <para>最大长度：128</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("object_api_name")]
    public string ObjectApiName { get; set; } = string.Empty;

    /// <summary>
    /// <para>组织名称</para>
    /// <para>- 相同上级的自定义组织中英文名称不允许重复。</para>
    /// <para>- 名称不能包含「/」「；」「;」字符。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：5</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("names")]
    public I18n[]? Names { get; set; }

    /// <summary>
    /// <para>组织名称</para>
    /// <para>- 相同上级的自定义组织中英文名称不允许重复。</para>
    /// <para>- 名称不能包含「/」「；」「;」字符。</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>语言信息，中文用zh-CN，英文用en-US</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>具体内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：中文示例</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>自定义组织编码 (不能与其他记录的编码重复)</para>
    /// <para>- 开启自动编码时，如果不传值会自动生成编码，否则以传入值为准</para>
    /// <para>- 未开启自动编码时，不传值不会自动生成编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：MDPD00000023</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>上级组织 ID</para>
    /// <para>- 可从 [批量查询自定义组织](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/custom_org/query)的 org_id 字段中获取。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>负责人 ID 列表。</para>
    /// <para>- 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取，ID 为返回值中的 ==employment_id==</para>
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
    /// <para>自定义组织生效时间</para>
    /// <para>- 填写格式： YYYY-MM-DD</para>
    /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
    /// <para>- 该接口只支持到最小单位为日</para>
    /// <para>- 日期范围要求:1900-01-01 ～ 9999-12-31</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>自动给「按自定义组织授权的角色」授权</para>
    /// <para>必填：否</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("org_roles")]
    public OrgRoleUpdate[]? OrgRoles { get; set; }

    /// <summary>
    /// <para>自动给「按自定义组织授权的角色」授权</para>
    /// </summary>
    public record OrgRoleUpdate
    {
        /// <summary>
        /// <para>角色key</para>
        /// <para>- api_name、security_group_id必须填一个</para>
        /// <para>- 可以通过页面「飞书人事-设置-组织配置」选择对应自定义组织，「字段配置-字段编码」获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：hcm_corehr_xxxxxx</para>
        /// </summary>
        [JsonPropertyName("api_name")]
        public string? ApiName { get; set; }

        /// <summary>
        /// <para>角色ID</para>
        /// <para>- api_name、security_group_id必须填一个</para>
        /// <para>- 可以通过[批量获取角色列表](https://open.larkoffice.com/document/server-docs/corehr-v1/authorization/list) 获取，数据为返回数据中的 data.items.id 值。筛选条件data.items.group_type == 3（组织角色），data.items.org_truncation 关联的组织有且仅有一个，data.items.org_truncation.org_key 等于当前查询自定义组织 object_api_name</para>
        /// <para>必填：否</para>
        /// <para>示例值：7034393015968122400</para>
        /// </summary>
        [JsonPropertyName("security_group_id")]
        public string? SecurityGroupId { get; set; }

        /// <summary>
        /// <para>被授权的员工 ID 列表</para>
        /// <para>- 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("employment_ids")]
        public string[]? EmploymentIds { get; set; }
    }

    /// <summary>
    /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
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
        /// <para>字段值，为 JSON 转义后的字符串。</para>
        /// <para>**注意：具体传值方式参见**[获取自定义字段的元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"231\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
