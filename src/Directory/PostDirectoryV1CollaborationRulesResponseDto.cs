// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="PostDirectoryV1CollaborationRulesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增可搜可见规则 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 新增可搜可见规则 响应体
/// <para>管理员视角新增可搜可见规则。用户需具备关联组织管理员权限。</para>
/// <para>接口ID：7442539768884723740</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/searchable-and-visible-rules/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollaboration_rule%2fcreate</para>
/// </summary>
public record PostDirectoryV1CollaborationRulesResponseDto
{
    /// <summary>
    /// <para>添加的规则ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：1212121</para>
    /// </summary>
    [JsonPropertyName("add_rule_id")]
    public string? AddRuleId { get; set; }
}
