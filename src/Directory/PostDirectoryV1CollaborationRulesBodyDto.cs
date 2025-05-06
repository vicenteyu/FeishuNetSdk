// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="PostDirectoryV1CollaborationRulesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增可搜可见规则 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 新增可搜可见规则 请求体
/// <para>管理员视角新增可搜可见规则。用户需具备关联组织管理员权限。</para>
/// <para>接口ID：7442539768884723740</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/searchable-and-visible-rules/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollaboration_rule%2fcreate</para>
/// </summary>
public record PostDirectoryV1CollaborationRulesBodyDto
{
    /// <summary>
    /// <para>实体数量之和需要小于100</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("subjects")]
    public CollaborationRuleEntities Subjects { get; set; } = new();

    /// <summary>
    /// <para>实体数量之和需要小于100</para>
    /// </summary>
    public record CollaborationRuleEntities
    {
        /// <summary>
        /// <para>用户 open id，可以从我方通讯录/组织架构接口中获得</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("open_user_ids")]
        public string[]? OpenUserIds { get; set; }

        /// <summary>
        /// <para>部门 open id，0代表全部成员，可以从我方通讯录/组织架构接口中获得</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("open_department_ids")]
        public string[]? OpenDepartmentIds { get; set; }

        /// <summary>
        /// <para>用户组 open id，可以从我方通讯录/组织架构接口中获得</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("open_group_ids")]
        public string[]? OpenGroupIds { get; set; }
    }

    /// <summary>
    /// <para>实体数量之和需要小于100</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("objects")]
    public CollaborationRuleEntities Objects { get; set; } = new();
}
