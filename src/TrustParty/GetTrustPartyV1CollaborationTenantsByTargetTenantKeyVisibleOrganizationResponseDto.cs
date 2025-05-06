// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="GetTrustPartyV1CollaborationTenantsByTargetTenantKeyVisibleOrganizationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取关联组织的部门和成员信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.TrustParty;
/// <summary>
/// 获取关联组织的部门和成员信息 响应体
/// <para>该接口会返回用户在外部部门下可见的下级部门、用户、用户组。</para>
/// <para>## 提示</para>
/// <para>使用 user_access_token 时，按照 admin 管理后台关联组织列表中针对用户设置的可见性规则进行校验；使用 tenant_access_token 时，按照应用互通界面中针对应用设置的可见性规则进行校验。</para>
/// <para>接口ID：7442539768884707356</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/visible_organization</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftrust_party-v1%2fcollaboration_tenant%2fvisible_organization</para>
/// </summary>
public record GetTrustPartyV1CollaborationTenantsByTargetTenantKeyVisibleOrganizationResponseDto
{
    /// <summary>
    /// <para>该部门下可见的部门、用户、用户组列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("collaboration_entity_list")]
    public CollaborationEntity[]? CollaborationEntityLists { get; set; }

    /// <summary>
    /// <para>该部门下可见的部门、用户、用户组列表</para>
    /// </summary>
    public record CollaborationEntity
    {
        /// <summary>
        /// <para>关联组织实体类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户类型</item>
        /// <item>department：部门类型</item>
        /// <item>group：用户组类型</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("collaboration_entity_type")]
        public string CollaborationEntityType { get; set; } = string.Empty;

        /// <summary>
        /// <para>部门ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：D096</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门的open ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：a0121196</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户的open ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("open_user_id")]
        public string? OpenUserId { get; set; }

        /// <summary>
        /// <para>用户的union_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：on_4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("union_user_id")]
        public string? UnionUserId { get; set; }

        /// <summary>
        /// <para>部门名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：test</para>
        /// </summary>
        [JsonPropertyName("department_name")]
        public string? DepartmentName { get; set; }

        /// <summary>
        /// <para>部门的国际化名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_department_name")]
        public I18nName? I18nDepartmentName { get; set; }

        /// <summary>
        /// <para>部门的国际化名称</para>
        /// </summary>
        public record I18nName
        {
            /// <summary>
            /// <para>中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn_name</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>日文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：ja_jp_name</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }

            /// <summary>
            /// <para>英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：en_name</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>部门顺序</para>
        /// <para>必填：否</para>
        /// <para>示例值：2000</para>
        /// </summary>
        [JsonPropertyName("department_order")]
        public string? DepartmentOrder { get; set; }

        /// <summary>
        /// <para>对方成员名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：test_user_name</para>
        /// </summary>
        [JsonPropertyName("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// <para>对方成员i18n名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_user_name")]
        public I18nName? I18nUserName { get; set; }

        /// <summary>
        /// <para>对方租户的成员头像</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_avatar")]
        public AvatarInfo? UserAvatar { get; set; }

        /// <summary>
        /// <para>对方租户的成员头像</para>
        /// </summary>
        public record AvatarInfo
        {
            /// <summary>
            /// <para>72*72像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>240*240像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>640*640像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_640")]
            public string? Avatar640 { get; set; }

            /// <summary>
            /// <para>原始头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_origin")]
            public string? AvatarOrigin { get; set; }
        }

        /// <summary>
        /// <para>用户组ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：a0121196</para>
        /// </summary>
        [JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// <para>用户组的open ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("open_group_id")]
        public string? OpenGroupId { get; set; }

        /// <summary>
        /// <para>对方用户组名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：test_user_name</para>
        /// </summary>
        [JsonPropertyName("group_name")]
        public string? GroupName { get; set; }

        /// <summary>
        /// <para>对方用户组i18n名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_group_name")]
        public I18nName? I18nGroupName { get; set; }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/TIx6jupqdAcfLY%2B51xMvNU=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
