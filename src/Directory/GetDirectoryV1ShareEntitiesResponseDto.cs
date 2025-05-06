// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="GetDirectoryV1ShareEntitiesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取关联组织双方共享成员范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 获取关联组织双方共享成员范围 响应体
/// <para>在创建规则时，需要获取本组织以及对方组织人员、部门和用户组的ID，且这些实体都应该在关联组织的共享范围内。本接口可获取关联组织双方的共享范围下的人员、部门和用户组。</para>
/// <para>接口ID：7442539768884609052</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollboration_share_entity%2flist</para>
/// </summary>
public record GetDirectoryV1ShareEntitiesResponseDto
{
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

    /// <summary>
    /// <para>分享的部门信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("share_departments")]
    public ShareDepartment[]? ShareDepartments { get; set; }

    /// <summary>
    /// <para>分享的部门信息</para>
    /// </summary>
    public record ShareDepartment
    {
        /// <summary>
        /// <para>部门open ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou-12121xxxx</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }

        /// <summary>
        /// <para>i18n文本</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18nText? Name { get; set; }

        /// <summary>
        /// <para>i18n文本</para>
        /// </summary>
        public record I18nText
        {
            /// <summary>
            /// <para>默认值</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("default_value")]
            public string DefaultValue { get; set; } = string.Empty;

            /// <summary>
            /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"en_us":"test"}</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public object? I18nValue { get; set; }
        }
    }

    /// <summary>
    /// <para>分享的用户组信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("share_groups")]
    public ShareGroup[]? ShareGroups { get; set; }

    /// <summary>
    /// <para>分享的用户组信息</para>
    /// </summary>
    public record ShareGroup
    {
        /// <summary>
        /// <para>用户组的open_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou-12121212</para>
        /// </summary>
        [JsonPropertyName("open_group_id")]
        public string? OpenGroupId { get; set; }

        /// <summary>
        /// <para>i18n文本</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18nText? Name { get; set; }

        /// <summary>
        /// <para>i18n文本</para>
        /// </summary>
        public record I18nText
        {
            /// <summary>
            /// <para>默认值</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("default_value")]
            public string DefaultValue { get; set; } = string.Empty;

            /// <summary>
            /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"en_us":"test"}</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public object? I18nValue { get; set; }
        }
    }

    /// <summary>
    /// <para>分享的用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("share_users")]
    public ShareUser[]? ShareUsers { get; set; }

    /// <summary>
    /// <para>分享的用户信息</para>
    /// </summary>
    public record ShareUser
    {
        /// <summary>
        /// <para>user open ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou-12121212</para>
        /// </summary>
        [JsonPropertyName("open_user_id")]
        public string? OpenUserId { get; set; }

        /// <summary>
        /// <para>i18n文本</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18nText? Name { get; set; }

        /// <summary>
        /// <para>i18n文本</para>
        /// </summary>
        public record I18nText
        {
            /// <summary>
            /// <para>默认值</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("default_value")]
            public string DefaultValue { get; set; } = string.Empty;

            /// <summary>
            /// <para>国际化值，key为zh_cn, ja_jp, en_us, value为对应的值</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"en_us":"test"}</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public object? I18nValue { get; set; }
        }

        /// <summary>
        /// <para>用户的头像</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public ImageLink? Avatar { get; set; }

        /// <summary>
        /// <para>用户的头像</para>
        /// </summary>
        public record ImageLink
        {
            /// <summary>
            /// <para>72*72像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://qwed.com</para>
            /// </summary>
            [JsonPropertyName("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>240*240像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://wssd.com</para>
            /// </summary>
            [JsonPropertyName("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>640*640像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://wssd.com</para>
            /// </summary>
            [JsonPropertyName("avatar_640")]
            public string? Avatar640 { get; set; }

            /// <summary>
            /// <para>原始头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https:inernal-api/image</para>
            /// </summary>
            [JsonPropertyName("avatar_origin")]
            public string? AvatarOrigin { get; set; }
        }
    }
}
