// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-06
//
// Last Modified By : yxr
// Last Modified On : 2025-05-06
// ************************************************************************
// <copyright file="GetDirectoryV1CollaborationTenantsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>管理员获取所有关联组织列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 管理员获取所有关联组织列表 响应体
/// <para>在创建规则时，需要知道对方组织的tenant key，可通过该接口获取有效的tenant key。只允许关联组织管理员权限调用。</para>
/// <para>接口ID：7442539768884592668</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollaboration_tenant%2flist</para>
/// </summary>
public record GetDirectoryV1CollaborationTenantsResponseDto : IPageableResponse<GetDirectoryV1CollaborationTenantsResponseDto.CollaborationTenant>
{
    /// <summary>
    /// <para>对方的关联组织信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CollaborationTenant[]? Items { get; set; }

    /// <summary>
    /// <para>对方的关联组织信息</para>
    /// </summary>
    public record CollaborationTenant
    {
        /// <summary>
        /// <para>关联组织列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：121s121234df</para>
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }

        /// <summary>
        /// <para>建联时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1724296400</para>
        /// <para>最大值：4884743675</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("connect_time")]
        public int? ConnectTime { get; set; }

        /// <summary>
        /// <para>租户头像</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public ImageLink? Avatar { get; set; }

        /// <summary>
        /// <para>租户头像</para>
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

        /// <summary>
        /// <para>租户品牌</para>
        /// <para>必填：否</para>
        /// <para>示例值：feishu</para>
        /// </summary>
        [JsonPropertyName("brand")]
        public string? Brand { get; set; }

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
        /// <para>i18n文本</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("short_name")]
        public I18nText? ShortName { get; set; }
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
