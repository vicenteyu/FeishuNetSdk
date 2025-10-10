// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询自定义组织信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询自定义组织信息 请求体
/// <para>根据传入的筛选条件批量查询自定义组织信息。不传任何筛选条件，默认获得该租户下所有的自定义组织数据。</para>
/// <para>接口ID：7358017162446520324</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fquery</para>
/// </summary>
public record PostCorehrV2CustomOrgsQueryBodyDto
{
    /// <summary>
    /// <para>组织类型编码，可在「飞书人事-设置-组织设置」中相应的自定义组织目录下查看</para>
    /// <para>必填：是</para>
    /// <para>示例值：custom_org_01</para>
    /// </summary>
    [JsonPropertyName("object_api_name")]
    public string ObjectApiName { get; set; } = string.Empty;

    /// <summary>
    /// <para>需要返回的字段列表。字段可填写的列表如下：</para>
    /// <para>- names</para>
    /// <para>- code</para>
    /// <para>- parent_id</para>
    /// <para>- manager_ids</para>
    /// <para>- description</para>
    /// <para>- effective_time</para>
    /// <para>- org_roles</para>
    /// <para>- active</para>
    /// <para>- org_id</para>
    /// <para>- custom_fields(自定义字段，需传入具体的"custom_api_name")</para>
    /// <para>详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query) ,比如:"shifouleixing_7795__c"</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("org_fields")]
    public string[]? OrgFields { get; set; }

    /// <summary>
    /// <para>需要返回的组织角色授权信息的列表。</para>
    /// <para>- org_role_fields 可选两种值</para>
    /// <para>- 角色key，可以通过页面「飞书人事-设置-组织配置」选择对应自定义组织，「字段配置-字段编码」获取</para>
    /// <para>- 角色ID，可以通过[批量获取角色列表](https://open.larkoffice.com/document/server-docs/corehr-v1/authorization/list) 获取，数据为返回数据中的 data.items.id 值。筛选条件data.items.group_type == 3（组织角色），data.items.org_truncation 关联的组织有且仅有一个，data.items.org_truncation.org_key 等于当前查询自定义组织 object_api_name</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("org_role_fields")]
    public string[]? OrgRoleFields { get; set; }

    /// <summary>
    /// <para>需要查询的组织 ID 列表。</para>
    /// <para>- ID 为 [获取自定义组织](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/custom_org/query)返回的 org_id 字段。</para>
    /// <para>- 不传不做 ID 相关限制</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("org_ids")]
    public string[]? OrgIds { get; set; }

    /// <summary>
    /// <para>只返回和传入编码相同的自定义组织数据。</para>
    /// <para>- 编码为[获取自定义组织](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/custom_org/query)返回的 code 字段。</para>
    /// <para>- 不传默认不做这个限制</para>
    /// <para>必填：否</para>
    /// <para>示例值：MDPD00000023</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>只返回 parent_id = 传入值 的自定义组织数据。</para>
    /// <para>- parent_id 为[获取自定义组织](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/custom_org/query)返回的 org_id 字段。</para>
    /// <para>- 不传默认不做这个限制</para>
    /// <para>- 自定义组织 ID 类型需要为 ==people_corehr_id==</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140964208476371111</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>只返回启用/停用的自定义组织数据。</para>
    /// <para>- 不传默认不做这个限制</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// <para>是否返回匹配规则。</para>
    /// <para>- 为 true 返回 ==match_rule_groups== 字段，否则不返回。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("need_match_rule")]
    public bool? NeedMatchRule { get; set; }
}
